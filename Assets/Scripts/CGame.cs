using UnityEngine;

public class CGame : MonoBehaviour
{
    public void SetPause()
    {
        Game.Pause = true;
    }

    public void DropPause()
    {
        Game.Pause = false;
    }
}