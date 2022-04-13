using UnityEngine;
using UnityEngine.InputSystem;

public class DisableOnD : MonoBehaviour
{
    public MainInputsObject mainInputsObject;
    void Start()
    {
        mainInputsObject.mainInputs.Normal.KeyDisable.performed += KeyDisableOnPerformed;
    }

    private void KeyDisableOnPerformed(InputAction.CallbackContext obj)
    {
        mainInputsObject.mainInputs.Disable();
    }
}
