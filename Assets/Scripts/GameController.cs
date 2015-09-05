using UnityEngine;
//using System.Collections;

public class GameController : MonoBehaviour
{
    public static GameController gameController;

    public enum GameState {GamePlay, MainMenu, PauseMenu}
    private GameState _gameState;

    public GameObject[] level1Enemies;
    public Transform enemiesSpawn;

    public void StateGamePlay()
    {
        StartGame();

        SetState(GameState.GamePlay);
    }

    public void StateMainMenu()
    {

        SetState(GameState.MainMenu);
    }

    public void StatePauseMenu()
    {

        SetState(GameState.PauseMenu);
    }

    public void SetState(GameState value)
    {
        switch (_gameState)
        {
            case GameState.GamePlay:
                //Логика выхода из состояния

                break;
            case GameState.MainMenu:
                break;
            case GameState.PauseMenu:
                break;
        }

        _gameState = value;
    }

    public void StartGame()
    {
        CreateEnemy();
    }

    public void Start()
    {
        StateGamePlay();
    }

    void Update()
    {
        switch (_gameState)
        {
            case GameState.GamePlay:
                break;
            case GameState.MainMenu:
                break;
            case GameState.PauseMenu:
                break;

        }
    }

    public void CreateEnemy()
    {
        GameObject enemy = (GameObject)Instantiate(GameController.gameController.level1Enemies[Random.Range(0, GameController.gameController.level1Enemies.Length)], Vector3.zero, Quaternion.identity);
        enemy.transform.SetParent(GameController.gameController.enemiesSpawn);

        Enemy.current.InitializeEnemy();
    }
}
