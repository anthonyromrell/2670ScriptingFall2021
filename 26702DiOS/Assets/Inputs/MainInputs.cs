// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/MainInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInputs"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""044126e5-3eed-4758-8be3-6ea3c4fa4128"",
            ""actions"": [
                {
                    ""name"": ""Key"",
                    ""type"": ""Button"",
                    ""id"": ""426f3066-4d18-46bd-a753-186c280daa04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyDisable"",
                    ""type"": ""Button"",
                    ""id"": ""f829c983-abbe-443b-896e-bd5b85ce21c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyEnable"",
                    ""type"": ""Button"",
                    ""id"": ""d340a852-c116-4c2d-866b-0c9e067d1823"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f2f6ae22-de16-4411-8b01-b490932bed96"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05dc40eb-592b-45d9-aeb4-16459484770a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyDisable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""417768ec-aef4-4a7d-a706-2f4b09b80123"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyEnable"",
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
        m_Normal_KeyDisable = m_Normal.FindAction("KeyDisable", throwIfNotFound: true);
        m_Normal_KeyEnable = m_Normal.FindAction("KeyEnable", throwIfNotFound: true);
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
    private readonly InputAction m_Normal_KeyDisable;
    private readonly InputAction m_Normal_KeyEnable;
    public struct NormalActions
    {
        private @MainInputs m_Wrapper;
        public NormalActions(@MainInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Key => m_Wrapper.m_Normal_Key;
        public InputAction @KeyDisable => m_Wrapper.m_Normal_KeyDisable;
        public InputAction @KeyEnable => m_Wrapper.m_Normal_KeyEnable;
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
                @KeyDisable.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnKeyDisable;
                @KeyDisable.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnKeyDisable;
                @KeyDisable.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnKeyDisable;
                @KeyEnable.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnKeyEnable;
                @KeyEnable.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnKeyEnable;
                @KeyEnable.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnKeyEnable;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Key.started += instance.OnKey;
                @Key.performed += instance.OnKey;
                @Key.canceled += instance.OnKey;
                @KeyDisable.started += instance.OnKeyDisable;
                @KeyDisable.performed += instance.OnKeyDisable;
                @KeyDisable.canceled += instance.OnKeyDisable;
                @KeyEnable.started += instance.OnKeyEnable;
                @KeyEnable.performed += instance.OnKeyEnable;
                @KeyEnable.canceled += instance.OnKeyEnable;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);
    public interface INormalActions
    {
        void OnKey(InputAction.CallbackContext context);
        void OnKeyDisable(InputAction.CallbackContext context);
        void OnKeyEnable(InputAction.CallbackContext context);
    }
}
