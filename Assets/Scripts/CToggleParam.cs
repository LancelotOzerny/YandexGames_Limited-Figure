using UnityEngine;
using UnityEngine.Events;

public abstract class CToggleParam : MonoBehaviour
{
    [SerializeField] private UnityEvent on;
    [SerializeField] private UnityEvent off;
    protected bool isOn;

    private void Start()
    {
        Load();
        Do();
    }

    public abstract void Load();
    public abstract void Save();

    public void Off()
    {
        isOn = false;
        off.Invoke();
        Save();
    }

    public void On()
    {
        isOn = true;
        on.Invoke();
        Save();
    }

    public void Change()
    {
        isOn = !isOn;
        Do();
    }

    private void Do()
    {
        if (isOn)
        {
            On();
        }
        else
        {
            Off();
        }
    }
}
