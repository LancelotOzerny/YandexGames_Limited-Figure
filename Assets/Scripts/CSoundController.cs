using UnityEngine;
using YG;

public class CSoundController : MonoBehaviour
{
    [SerializeField] private AudioSource audio = null;

    private void Awake()
    {
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    public void Play()
    {
        if (audio != null && YandexGame.savesData.soundsOn)
        {
            audio.Play();
        }
    }
}
