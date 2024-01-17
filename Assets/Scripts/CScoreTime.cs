using UnityEngine;
using UnityEngine.UI;
using YG;

public class CScoreTime : MonoBehaviour
{
    [SerializeField] private Text text = null;
    [SerializeField] private string leaderboard = "test";

    private int score = 0;
    private float timer = 0;

    private void Awake()
    {
        if (text == null)
        {
            text = GetComponent<Text>();
        }
    }

    private void Start()
    {
        SetText();
        timer = 1.0f;
    }

    private void Update()
    {
        if (Game.Pause)
        {
            return;
        }

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = 1.0f;
            score++;
            SetText();
            SaveRecord();
        }
    }

    private void SetText()
    {
        if (text != null)
        {
            text.text = ToTime(score);
        }
    }

    private void SaveRecord()
    {
        if (YandexGame.savesData.bestScore < score)
        {
            YandexGame.NewLBScoreTimeConvert(leaderboard, score * 1000);
            YandexGame.savesData.bestScore = score;
            YandexGame.SaveProgress();
        }
    }

    public static string ToTime(int time, bool color = false)
    {
        string result = string.Empty;
        string minutes = (time / 60).ToString();
        string seconds = (time % 60).ToString();

        if (minutes.Length == 1)
        {
            minutes = '0' + minutes;
        }

        if (seconds.Length == 1)
        {
            seconds = '0' + seconds;
        }

        if (color)
        {
            result = $"<color=#79BDFD>{minutes}</color>:<color=#79D5F9>{seconds}</color>";
        }
        else
        {
            result = $"{minutes}:{seconds}";
        }

        return result;
    }
}
