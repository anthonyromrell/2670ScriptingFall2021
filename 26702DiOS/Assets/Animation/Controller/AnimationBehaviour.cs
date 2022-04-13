using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class AnimationBehaviour : MonoBehaviour
{
    private Animator animatorObj;
    private ControllerActions controllerActions;
    private readonly int keyDown = Animator.StringToHash("KeyDown");

    private void Start()
    {
        controllerActions = new ControllerActions();
        controllerActions.Normal.Key.performed += KeyOnPerformed;
        controllerActions.Enable();
        animatorObj = GetComponent<Animator>();
    }

    private void KeyOnPerformed(InputAction.CallbackContext obj)
    {
        Debug.Log("key");
        animatorObj.SetTrigger(keyDown);
    }
}
