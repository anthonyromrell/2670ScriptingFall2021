using UnityEngine;
using UnityEngine.InputSystem;

public class MainInputsActions : MonoBehaviour
{

    public MainInputsObject mainInputsObject;
    public void OnEnable()
    {
        mainInputsObject.mainInputs.Normal.Key.performed += KeyOnPerformed;
    }
    
    private void KeyOnPerformed(InputAction.CallbackContext obj)
    {
        Debug.Log(obj);
    }
}
