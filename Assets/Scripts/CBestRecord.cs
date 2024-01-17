using UnityEngine;
using UnityEngine.UI;
using YG;

public class CBestRecord : MonoBehaviour
{
    [SerializeField] private Text text = null;

    private void Awake()
    {
        if (text == null)
        {
            text = GetComponent<Text>();
        }
    }

    void Start()
    {
        text.text = CScoreTime.ToTime(YandexGame.savesData.bestScore, true);
    }
}
