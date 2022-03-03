using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimBehaviour : MonoBehaviour
{
    private GameInputs animInputs;

    private void Awake()
    {
        animInputs = new GameInputs();
        animInputs.Normal.Jump.performed += JumpOnPerformed;
    }

    private void JumpOnPerformed(InputAction.CallbackContext obj)
    {
        print(obj);
    }
}
