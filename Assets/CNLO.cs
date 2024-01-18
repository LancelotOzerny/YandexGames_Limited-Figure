using UnityEngine;

public class CNLO : CIntervalGenerator
{
    [SerializeField] private GameObject bullet = null;
    [SerializeField] private Transform player = null;

    private void Awake()
    {
        if ( player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }
    }

    protected override void Generate()
    {
        if (this.bullet == null)
        {
            return;
        }

        GameObject bullet = Instantiate(this.bullet);
        bullet.transform.position = transform.position;
        bullet.GetComponent<CBullet>().SetTarget(player.transform.position);
    }
}
