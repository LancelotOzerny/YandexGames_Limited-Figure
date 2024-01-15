using YG;

public class CSoundsParam : CToggleParam
{
    public override void Load()
    {
        this.isOn = YandexGame.savesData.soundsOn;
    }

    public override void Save()
    {
        YandexGame.savesData.soundsOn = this.isOn;
        YandexGame.SaveProgress();
    }
}
