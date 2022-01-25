using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.name);
    }
}
