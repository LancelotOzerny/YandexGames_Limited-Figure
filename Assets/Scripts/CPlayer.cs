using UnityEngine;

public class CPlayer : MonoBehaviour
{
    [SerializeField] private CRoad road;
    [SerializeField] private float speed = 4f;

    private void Start()
    {
        if (road == null)
        {
            return;
        }

        transform.position = road.CurrentPoint.position;
        road.Next();
    }

    private void Update()
    {
        if (road == null)
        {
            return;
        }

        float distance = Vector2.Distance(transform.position, road.CurrentPoint.position);
        transform.position = Vector2.Lerp
        (
            transform.position, 
            road.CurrentPoint.position,
            speed / distance * Time.deltaTime
        );

        if (distance < 0.05f)
        {
            road.Next();
        }
    }
}
