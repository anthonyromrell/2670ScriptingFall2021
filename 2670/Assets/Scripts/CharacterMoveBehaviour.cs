using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMoveBehaviour : MonoBehaviour
{
    private CharacterController cc;
    private Vector3 movement;
    public FloatData speed;

    public enum AxisInputs
    {
        Horizontal, Vertical
    }

    public AxisInputs horizontalInput = AxisInputs.Horizontal,
        verticalInput = AxisInputs.Vertical;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        movement.Set(
            Input.GetAxis(horizontalInput.ToString()),
            0,
            Input.GetAxis(verticalInput.ToString()));
        movement *= speed.Value;
        movement *= Time.deltaTime;
        cc.Move(movement);
    }
}
