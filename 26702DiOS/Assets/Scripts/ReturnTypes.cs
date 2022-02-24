using System;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTypes : MonoBehaviour
{

    public List<int> intList;
     
    public int score;
    public void Start()
    {
        print("Go Team!");

        score = 10 + 3;

        score = Addition(10, 3);
        score = Subtraction(3, 1);
    }

    

    public int Addition(int one, int two)
    {
        return one + two;
    }

    public int Subtraction(int one, int two)
    {
        return one - two;
    } 
    
}
