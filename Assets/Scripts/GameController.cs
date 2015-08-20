using UnityEngine;
//using System.Collections;

public class GameController : MonoBehaviour
{
    public enum GameState {GamePlay, MainMenu, PauseMenu}
    private GameState _gameState;

    public delegate void StateChanger();
    //Event's
    public event StateChanger StartGameEvent;
    public event StateChanger MainMenuEvent;
    public event StateChanger PauseEvent;

    public void StateGamePlay()
    {
        SetState(GameState.GamePlay);
        StartGame();
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
        }

        _gameState = value;
    }

    public void StartGame()
    {
        
    }

    public void Start()
    {
        StartGameEvent += StateGamePlay;
        MainMenuEvent += StateMainMenu;
        PauseEvent += StatePauseMenu;
    }

    public class Enemy
    {
        public float MaxHp;
        public float Hp;
        public GameObject ModelPrefab;


    }
}
