using System;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class GameStatesBehaviour : MonoBehaviour
{
    public GameStates gameStates;
    public UnityEvent startingEvent, playingEvent, returningEvent;

    private void Start()
    {
        CheckGameStates();
    }

    public void CheckGameStates()
    {
        switch (gameStates.currentState)
        {
            case GameStates.States.Starting:
                startingEvent.Invoke();
                break;
            case GameStates.States.Playing:
                playingEvent.Invoke();
                break;
            case GameStates.States.Returning:
                returningEvent.Invoke();
                break;
            default:
                startingEvent.Invoke();
                break;
        }
    }
}
