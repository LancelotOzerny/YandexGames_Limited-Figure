using UnityEngine;

public class CBullet : MonoBehaviour
{
    [SerializeField] private Vector2 target = Vector2.zero;
    [SerializeField] private float speed = 4.0f;

    public void SetTarget(Vector2 target)
    {
        this.target = target;
        SetRotation();
    }

    public void SetRotation()
    {
        float A = transform.position.x - target.x;
        float B = transform.position.y - target.y;
        float C = Mathf.Sqrt(A * A + B * B);

        float cos = (B * B + C * C - A * A) / (2 * B * C);
        float angle = Mathf.Acos(cos) * 57.3f;

        if (A > 0)
        {
            angle = -angle;
        }

        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }

    private void Update()
    {
        if (Game.Pause)
        {
            return;
        }

        float distance = Vector2.Distance(transform.position, target);
        if (distance < 0.2f)
        {
            Destroy(this.gameObject);
        }
        transform.position = Vector2.Lerp(transform.position, target, speed * Time.deltaTime / distance);
    }
}
