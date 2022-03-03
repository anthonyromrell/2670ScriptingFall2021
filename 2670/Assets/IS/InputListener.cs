using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputListener : MonoBehaviour
{
    
    public float force = 100;
    private GameInputs gameInputs;
    private Vector3 direction, forces;
    private new Rigidbody rigidbody;

    private void Start()
    {
        direction = new Vector3();
        forces = new Vector3();
        rigidbody = GetComponent<Rigidbody>();
        gameInputs = new GameInputs();
        gameInputs.Enable();
        gameInputs.Normal.Jump.performed += JumpOnPerformed;
        gameInputs.Normal.Move.performed += MoveOnPerformed;
    }

    private void FixedUpdate()
    {
        var input = gameInputs.Normal.Move.ReadValue<Vector2>();
        direction.x = input.x*force*2;
        rigidbody.AddForce(direction, ForceMode.Force);
    }

    private void MoveOnPerformed(InputAction.CallbackContext obj)
    {
        //rigidbody.AddForce(obj.ReadValue<Vector2>()*force); 
        //rigidbody.velocity = obj.ReadValue<Vector2>()*force*10;
    }

    private void JumpOnPerformed(InputAction.CallbackContext obj)
    {
        print(obj);
        forces.Set(0, force*10f, 0);
        rigidbody.AddForce(forces, ForceMode.Force);
    } 
}
