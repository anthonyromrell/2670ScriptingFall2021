using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    public MainInputsObject mainInputsObject;
    public void OnEnable()
    {
        mainInputsObject.mainInputs.Normal.Key.performed += JumpOnKey;
    }

    private void JumpOnKey(InputAction.CallbackContext obj)
    {
        Debug.Log("Jump");
    }
}
