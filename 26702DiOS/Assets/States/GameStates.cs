using UnityEngine;

[CreateAssetMenu]
public class GameStates : ScriptableObject
{
    public enum States
    {
        Starting,
        Playing,
        Returning
    }

    public States currentState;


    public void ToStarting()
    {
        currentState = States.Starting;
    }
    
    public void ToPlaying()
    {
        currentState = States.Playing;
    }
    
    public void ToReturning()
    {
        currentState = States.Returning;
    }
    
}
