using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FireWithInput : MonoBehaviour
{
    private GameInputs gameInputs;

    private void Awake()
    {
        gameInputs = new GameInputs();
        gameInputs.Enable();
        gameInputs.Firing.Fire.performed += FireOnPerformed;
    }

    private void FireOnPerformed(InputAction.CallbackContext obj)
    {
        print(obj);
    }
}
