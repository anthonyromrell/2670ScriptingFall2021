// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/GameInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""Nornal"",
            ""id"": ""cef11285-254a-4b1b-87b0-375ee8146166"",
            ""actions"": [
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""25b94d92-55bc-40bd-882a-fb167e3a9b6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""31a68233-b1f0-4398-b101-3c7fd811e882"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7e22559c-46da-46cc-be40-c50570b39758"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""558b0be9-d42e-466b-a0f8-1cbd96bf4b68"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa0fd326-7e5d-48fa-9089-fa60a6df708f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Axis"",
                    ""id"": ""a473bc19-9067-4d29-a55a-62c442b6320a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""93c2b8a4-2e65-4278-bc2e-0d0514cb3d5c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0b65414f-296d-47ab-9b13-b11293f8086d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0d5fde1f-8f83-400b-a107-e7f7376b4b1f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bbd0630e-8b95-4e78-a78d-78b2eb30f59a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Axis"",
                    ""id"": ""b1d325f2-87a4-457a-8f33-ad857814e432"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b137d87e-eb24-46fd-83fa-1c4a4cb23212"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7f3d0f2f-be24-4803-a2f2-f97250fab87e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""07e24a17-5f3d-4503-844b-c661eb4429c4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""392e180f-a081-4e1f-899a-37856721e9c6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Firing"",
            ""id"": ""bb334851-8a64-4747-a654-fc72ada4ca65"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""f1f391aa-1edf-4267-806e-b4f3a41496f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""945c32ec-bc2d-4bfd-a71f-c90a874862a3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Nornal
        m_Nornal = asset.FindActionMap("Nornal", throwIfNotFound: true);
        m_Nornal_jump = m_Nornal.FindAction("jump", throwIfNotFound: true);
        m_Nornal_A = m_Nornal.FindAction("A", throwIfNotFound: true);
        m_Nornal_Move = m_Nornal.FindAction("Move", throwIfNotFound: true);
        // Firing
        m_Firing = asset.FindActionMap("Firing", throwIfNotFound: true);
        m_Firing_Fire = m_Firing.FindAction("Fire", throwIfNotFound: true);
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

    // Nornal
    private readonly InputActionMap m_Nornal;
    private INornalActions m_NornalActionsCallbackInterface;
    private readonly InputAction m_Nornal_jump;
    private readonly InputAction m_Nornal_A;
    private readonly InputAction m_Nornal_Move;
    public struct NornalActions
    {
        private @GameInputs m_Wrapper;
        public NornalActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @jump => m_Wrapper.m_Nornal_jump;
        public InputAction @A => m_Wrapper.m_Nornal_A;
        public InputAction @Move => m_Wrapper.m_Nornal_Move;
        public InputActionMap Get() { return m_Wrapper.m_Nornal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NornalActions set) { return set.Get(); }
        public void SetCallbacks(INornalActions instance)
        {
            if (m_Wrapper.m_NornalActionsCallbackInterface != null)
            {
                @jump.started -= m_Wrapper.m_NornalActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_NornalActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_NornalActionsCallbackInterface.OnJump;
                @A.started -= m_Wrapper.m_NornalActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_NornalActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_NornalActionsCallbackInterface.OnA;
                @Move.started -= m_Wrapper.m_NornalActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_NornalActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_NornalActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_NornalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public NornalActions @Nornal => new NornalActions(this);

    // Firing
    private readonly InputActionMap m_Firing;
    private IFiringActions m_FiringActionsCallbackInterface;
    private readonly InputAction m_Firing_Fire;
    public struct FiringActions
    {
        private @GameInputs m_Wrapper;
        public FiringActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Firing_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Firing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FiringActions set) { return set.Get(); }
        public void SetCallbacks(IFiringActions instance)
        {
            if (m_Wrapper.m_FiringActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_FiringActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_FiringActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_FiringActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_FiringActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public FiringActions @Firing => new FiringActions(this);
    public interface INornalActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IFiringActions
    {
        void OnFire(InputAction.CallbackContext context);
    }
}
