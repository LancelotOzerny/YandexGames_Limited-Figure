using YG;

public class CMusicParam : CToggleParam
{
    public override void Load()
    {
        this.isOn = YandexGame.savesData.musicOn;
    }

    public override void Save()
    {
        YandexGame.savesData.musicOn = this.isOn;
        YandexGame.SaveProgress();
    }
}
