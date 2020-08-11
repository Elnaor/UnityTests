// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerMouvement"",
            ""id"": ""40070eb7-66b5-4271-aa40-72b299ffc1b1"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""35bc335a-b210-4e00-aac1-03732a2f869a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""5da9f805-af27-40d9-b233-9c5afaf7d56e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""2808563b-f225-4a50-b9d0-b57d23eb8e9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""1e79e3c9-5126-4f30-b8a0-81d6c5917765"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e11c317-9f97-4daf-8413-7e87893285af"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2adf9d6c-c519-489b-aaf1-668983b9d869"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f2a758c-bfa3-4877-b1cf-0c27565d9e11"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa23fb5f-2255-4727-94de-6818bb2eef09"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerMouvement
        m_PlayerMouvement = asset.FindActionMap("PlayerMouvement", throwIfNotFound: true);
        m_PlayerMouvement_Jump = m_PlayerMouvement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMouvement_Attack = m_PlayerMouvement.FindAction("Attack", throwIfNotFound: true);
        m_PlayerMouvement_Move = m_PlayerMouvement.FindAction("Move", throwIfNotFound: true);
        m_PlayerMouvement_Rotate = m_PlayerMouvement.FindAction("Rotate", throwIfNotFound: true);
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

    // PlayerMouvement
    private readonly InputActionMap m_PlayerMouvement;
    private IPlayerMouvementActions m_PlayerMouvementActionsCallbackInterface;
    private readonly InputAction m_PlayerMouvement_Jump;
    private readonly InputAction m_PlayerMouvement_Attack;
    private readonly InputAction m_PlayerMouvement_Move;
    private readonly InputAction m_PlayerMouvement_Rotate;
    public struct PlayerMouvementActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerMouvementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerMouvement_Jump;
        public InputAction @Attack => m_Wrapper.m_PlayerMouvement_Attack;
        public InputAction @Move => m_Wrapper.m_PlayerMouvement_Move;
        public InputAction @Rotate => m_Wrapper.m_PlayerMouvement_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMouvement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMouvementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMouvementActions instance)
        {
            if (m_Wrapper.m_PlayerMouvementActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnAttack;
                @Move.started -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerMouvementActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_PlayerMouvementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public PlayerMouvementActions @PlayerMouvement => new PlayerMouvementActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerMouvementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
