using UnityEngine;

public class CPlayer : MonoBehaviour
{
    [SerializeField] private CRoad road;
    [SerializeField] private float speed = 4f;
    [SerializeField] private bool reverse;

    private void Start()
    {
        if (road == null)
        {
            return;
        }

        transform.position = road.CurrentPoint.position;
        ChangePoint();
    }

    /// <summary>
    /// Метод, который позволяет изменить направление движения персонажа
    /// </summary>
    public void Reverse()
    {
        reverse = !reverse;
        ChangePoint();
    }

    /// <summary>
    /// Метод, который в зависимости от направления движения устанавливает следующую точку
    /// </summary>
    private void ChangePoint()
    {
        if (reverse)
        {
            road.Prev();
        }
        else
        {
            road.Next();
        }
    }

    private void Update()
    {
        if (road == null || Game.Pause)
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
