using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastBehaviour : MonoBehaviour
{
    public HitData hit;
    public GameAction gameAction;
    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    public void RunRayCast()
    {
        
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit.value, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.value.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }   

        var sendObj = hit.value.collider.gameObject;
        gameAction.Raise(sendObj);
    }
}
