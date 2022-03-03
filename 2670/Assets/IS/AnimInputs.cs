// GENERATED AUTOMATICALLY FROM 'Assets/IS/AnimInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @AnimInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @AnimInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""AnimInputs"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""1f34aa17-5bc9-4ee0-83e8-aca588861b55"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bd0819df-ec56-4955-87ad-0537cb6e6c6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""27bce88d-d174-4ba4-ba1c-ca680110ee17"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""892f1887-952a-44db-945c-bb8a5e200eab"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""WallClimb"",
            ""id"": ""ba4ae960-dc49-4f0c-87ee-a365350347cb"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""9338643e-8712-4e1b-bcbb-7f2428710389"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f5a0bffe-5b13-4858-80ba-e188a7388dc2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
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
        m_Normal_Jump = m_Normal.FindAction("Jump", throwIfNotFound: true);
        // WallClimb
        m_WallClimb = asset.FindActionMap("WallClimb", throwIfNotFound: true);
        m_WallClimb_Newaction = m_WallClimb.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_Normal_Jump;
    public struct NormalActions
    {
        private @AnimInputs m_Wrapper;
        public NormalActions(@AnimInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Normal_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);

    // WallClimb
    private readonly InputActionMap m_WallClimb;
    private IWallClimbActions m_WallClimbActionsCallbackInterface;
    private readonly InputAction m_WallClimb_Newaction;
    public struct WallClimbActions
    {
        private @AnimInputs m_Wrapper;
        public WallClimbActions(@AnimInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_WallClimb_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_WallClimb; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WallClimbActions set) { return set.Get(); }
        public void SetCallbacks(IWallClimbActions instance)
        {
            if (m_Wrapper.m_WallClimbActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_WallClimbActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_WallClimbActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_WallClimbActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_WallClimbActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public WallClimbActions @WallClimb => new WallClimbActions(this);
    public interface INormalActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IWallClimbActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
