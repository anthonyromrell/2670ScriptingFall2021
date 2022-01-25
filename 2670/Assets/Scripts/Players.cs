using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour, IMove
{
    public ScriptableObject powerUp;
    public IPowerUp temp;
    private IPowerUp powerUpObj;
    
    private void Start()
    {
        powerUpObj = powerUp as IPowerUp;
        print(powerUpObj.PowerLevel);
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
