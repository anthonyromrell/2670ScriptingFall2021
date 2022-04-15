using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu]
public class ActionObject : ScriptableObject
{
   private GameInputs gameInputs;
   public UnityEvent onPerformedEvent;
   private void OnEnable()
   {
      gameInputs = new GameInputs();
      gameInputs.Enable();
      gameInputs.Nornal.A.performed += AOnPerformed;
   }

   private void AOnPerformed(InputAction.CallbackContext obj)
   {
      onPerformedEvent.Invoke();
   }
}
