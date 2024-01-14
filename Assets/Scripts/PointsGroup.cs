using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PointsGroup
{
    [SerializeField] private List<Transform> points = new List<Transform>();
    
    public List<Transform> Points
    { 
        get 
        { 
            return points; 
        } 
    }
}
