using System;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{ 
    void Start()
    {
        
    }

    protected virtual void Update()
    {
        Run();
    }

    protected void Run()
    {
        Debug.Log("Run");
    }

    protected void DoDamage()
    {
        Debug.Log("Damage");
    }
}
