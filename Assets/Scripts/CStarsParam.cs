using YG;

public class CStarsParam: CToggleParam
{
    public override void Load()
    {
        this.isOn = YandexGame.savesData.starsOn;
    }

    public override void Save()
    {
        YandexGame.savesData.starsOn = this.isOn;
        YandexGame.SaveProgress();
    }
}
