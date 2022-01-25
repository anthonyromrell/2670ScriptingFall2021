using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHealth, IMove
{
    public float Health { get; set; }
    public void Start()
    {
        throw new System.NotImplementedException();
    }

    public float Speed { get; set; }

    public void Walk()
    {
        throw new System.NotImplementedException();
    }

    public void Run()
    {
        throw new System.NotImplementedException();
    }

    public void Jump()
    {
        throw new System.NotImplementedException();
    }

    public void Idle()
    {
        throw new System.NotImplementedException();
    }
}
