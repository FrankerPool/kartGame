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
    public void GameOverLose()
    {
        canvasLose.SetActive(true);
    }
    public void GameOverWin()
    {
        canvasWin.SetActive(true);
    }
    public void updatePoints(int curentPoints)
    {
        pointsTXT.text = curentPoints.ToString();
    }
    public void OnclickBTNMenu()
    {
        GameManager.instanceGameManager.resetGame();
    }
}
