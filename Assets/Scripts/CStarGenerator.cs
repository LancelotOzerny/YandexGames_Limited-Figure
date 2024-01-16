using UnityEngine;
using UnityEngine.UI;

public class CStarGenerator : CIntervalGenerator
{
    [Header("Generator Properties")]
    [SerializeField] private Image area;
    [SerializeField] private GameObject star;

    protected override void Generate()
    {
        if (star == null)
        {
            return;
        }

        Instantiate(star, transform);
        star.transform.position = Vector3.zero;

        int width = (int)(area.rectTransform.rect.width / 2);
        int height = (int)(area.rectTransform.rect.height / 2);

        star.GetComponent<RectTransform>().position = new Vector2(
            rand.Next(-width, width),
            rand.Next(-height, height)
        );
    }
}
