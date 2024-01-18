using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CPlayerRotate : MonoBehaviour
{
    [SerializeField] private CRoad road = null;

    private Vector2 Player { get => transform.position; }
    private Vector2 Target { get => road.CurrentPoint.position; }

    private void Update()
    {
        SetRotation();
    }

    public void SetRotation()
    {
        Vector3 targetDirection = Target - Player;
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, targetDirection);
        transform.rotation = Quaternion.Euler(0, 0, targetRotation.eulerAngles.z + 90);
    }
}
