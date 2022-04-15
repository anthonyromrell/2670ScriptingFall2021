using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class GameInputsHandler : MonoBehaviour
{
    public float speed = 10f;
    private CharacterController characterController;
    private GameInputs gameInputs;
    private Vector3 direction = Vector3.zero;
    private IEnumerator Start()
    {
        characterController = GetComponent<CharacterController>();
        gameInputs = new GameInputs();
        gameInputs.Enable();
        gameInputs.Nornal.jump.performed += JumpOnPerformed;
        yield return new WaitForSeconds(3);
        gameInputs.Disable();
        yield return new WaitForSeconds(3);
        gameInputs.Enable();
    }
    private void JumpOnPerformed(InputAction.CallbackContext obj)
    {
        print(obj);
    }

    private void Update()
    {
        direction.x = gameInputs.Nornal.Move.ReadValue<Vector2>().x;
        direction *= Time.deltaTime * speed;
        characterController.Move(direction);
    }
}
