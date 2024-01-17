using System.Collections.Generic;
using UnityEngine;

public class CRoad : MonoBehaviour
{
    [SerializeField] private List<PointsGroup> points = new List<PointsGroup>();
    [SerializeField] private int currentGroup = 0;
    [SerializeField] private int currentPoint = 0;

    public Transform CurrentPoint
    {
        get
        {
            return points[currentGroup].Points[currentPoint];
        }
    }

    public void SetCurrentGroup(int value)
    {
        currentGroup = value;
    }

    public void Next()
    {
        if (++currentPoint >= points[currentGroup].Points.Count)
        {
            currentPoint = 0;
        }
    }

    public void Prev()
    {
        if (--currentPoint < 0)
        {
            currentPoint = points[currentGroup].Points.Count - 1;
        }
    }
}
