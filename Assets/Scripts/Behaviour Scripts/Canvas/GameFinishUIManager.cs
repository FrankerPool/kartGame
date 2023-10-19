using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameFinishUIManager : MonoBehaviour
{
    static public GameFinishUIManager instanceGameFinishUIManager;
    //canvas in scene
    public GameObject canvasLose,canvasWin;
    public TextMeshProUGUI pointsTXT;
    private void Awake()
    {
        instanceGameFinishUIManager = this;
    }
    //active the lose canvas
    public void GameOverLose()
    {
        canvasLose.SetActive(true);
    }
    //active win canvas
    public void GameOverWin()
    {
        canvasWin.SetActive(true);
    }
    //update text points
    public void updatePoints(int curentPoints)
    {
        pointsTXT.text = curentPoints.ToString();
    }
    //onclick btn menu return menu
    public void OnclickBTNMenu()
    {
        GameManager.instanceGameManager.resetGame();
    }
}
