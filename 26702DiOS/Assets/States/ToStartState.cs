using UnityEngine;

public class ToStartState : MonoBehaviour
{
    public GameStates gameStates;

    private void Start()
    {
        gameStates.currentState = GameStates.States.Starting;
    }
}
