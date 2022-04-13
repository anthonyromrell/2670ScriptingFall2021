// GENERATED AUTOMATICALLY FROM 'Assets/Animation/Controller/ControllerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControllerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControllerActions"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""efb8cee6-c97a-4155-a1c0-80829bc206a2"",
            ""actions"": [
                {
                    ""name"": ""Key"",
                    ""type"": ""Button"",
                    ""id"": ""0d75ea14-03e5-403d-a9cf-a6731614dab1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""753a288c-daf1-46ae-b4ab-2d7c4be7d5b2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Normal
        m_Normal = asset.FindActionMap("Normal", throwIfNotFound: true);
        m_Normal_Key = m_Normal.FindAction("Key", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Normal
    private readonly InputActionMap m_Normal;
    private INormalActions m_NormalActionsCallbackInterface;
    private readonly InputAction m_Normal_Key;
    public struct NormalActions
    {
        private @ControllerActions m_Wrapper;
        public NormalActions(@ControllerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Key => m_Wrapper.m_Normal_Key;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @Key.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnKey;
                @Key.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnKey;
                @Key.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnKey;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Key.started += instance.OnKey;
                @Key.performed += instance.OnKey;
                @Key.canceled += instance.OnKey;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);
    public interface INormalActions
    {
        void OnKey(InputAction.CallbackContext context);
    }
}
