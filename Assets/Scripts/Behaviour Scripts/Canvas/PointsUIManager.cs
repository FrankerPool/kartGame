using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsUIManager : MonoBehaviour
{
    static public PointsUIManager instancePointsUIManager;
    public TextMeshProUGUI pointsTXT;
    private void Awake()
    {
        instancePointsUIManager = this;
    }
    public void updatePoints(int curentPoints)
    {
        pointsTXT.text = curentPoints.ToString();
    }
}
