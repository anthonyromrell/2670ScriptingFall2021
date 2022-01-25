using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovementBase : MonoBehaviour
{
    
}

public interface IMove
{
    public float Speed { get; set;}

    public void Walk();
    public void Run();
    public void Jump();
    public void Idle();
}