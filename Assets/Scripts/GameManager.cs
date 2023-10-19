using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//states of game
public enum GameState
{
    inGame,pauseGame,gameOver
}
public class GameManager : MonoBehaviour
{
    static public GameManager instanceGameManager;
    public GameState currentGameState = GameState.pauseGame;
    [HideInInspector]public int points = 10;
    public int targetPoints;
    //
    private void Awake()
    {
        instanceGameManager = this;
    }
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        GameFinishUIManager.instanceGameFinishUIManager.GameOverLose();
        currentGameState = GameState.gameOver;
        Time.timeScale = 0;
    }
    public void initGame()
    {
        PointsUIManager.instancePointsUIManager.updatePoints(points);
        currentGameState = GameState.inGame;
    }
    public void resetGame()
    {
        //recargo la scena del juego
        SceneManager.LoadScene(0);
    }
    public void winGame()
    {
        GameFinishUIManager.instanceGameFinishUIManager.GameOverWin();
        GameFinishUIManager.instanceGameFinishUIManager.updatePoints(points);
        currentGameState = GameState.gameOver;
        Time.timeScale = 0;
    }
    public void addPoints(int value)
    {
        points += value;
        PointsUIManager.instancePointsUIManager.updatePoints(points);
        if (points >= targetPoints)
            winGame();
    }
    public void restPoints(int value)
    {
        points -= value;
        PointsUIManager.instancePointsUIManager.updatePoints(points);
        if (points < 0)
            GameOver();
    }
}
