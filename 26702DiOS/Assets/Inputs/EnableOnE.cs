using UnityEngine;
using UnityEngine.InputSystem;

public class EnableOnE : MonoBehaviour
{
    public MainInputsObject mainInputsObject;

    private void OnEnable()
    {
        mainInputsObject.mainInputs.Normal.KeyEnable.performed += KeyEnableOnPerformed;
    }

    private void KeyEnableOnPerformed(InputAction.CallbackContext obj)
    {
        mainInputsObject.mainInputs.Enable();
    }
}
