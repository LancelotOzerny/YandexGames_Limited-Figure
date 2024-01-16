using UnityEngine;
using YG;

public class CStar : MonoBehaviour
{
    private static System.Random rand = new System.Random();

    private void Awake()
    {
        if (YandexGame.savesData.starsOn == false)
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        int scale = rand.Next(1, 10);
        transform.localScale = new Vector2((float)scale / 10, (float)scale / 10);
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
