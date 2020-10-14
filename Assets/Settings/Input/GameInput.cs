// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""GroundInput"",
            ""id"": ""f73954b9-5272-48b2-8dbc-94a8dc252128"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c9adebb3-ee76-4d19-9f47-d5dcf1cf6d74"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""a09f0514-0b94-4e7a-8fc3-0af90716669b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""fd65f72a-3170-47da-987f-676f69b678d4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""eeec160a-5136-4272-836d-3a253d927a44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""00f0d111-1961-4716-9344-4767ce22f749"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""9096918f-582b-4d8a-ba99-63a7bd772727"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""Button"",
                    ""id"": ""5e30632e-6111-4ffa-b111-da10c158c891"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1cd2a8f3-2f27-40ab-bc85-1708f1fd562c"",
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
                    ""id"": ""eef022e6-99cb-4fc2-9d6f-a4674ddf5d9b"",
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
                    ""id"": ""d1cc0e8e-88ce-4940-b00f-687a15a04b37"",
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
                    ""id"": ""b98ccc81-0b22-4382-b716-f7f4eb53218a"",
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
                    ""id"": ""fdad22ce-171c-48c4-8d17-82ab59ae8b50"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""98a59804-8c1e-47dc-9a76-dfb21849c591"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2d76a21-76e4-4609-8d43-1e1f3a0a415f"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6bf8df5-7923-4e35-b6ad-3989261f1c91"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e2ac1e7-dc6e-4504-a3f0-0a36a0c9a69b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ee8b78f-dcec-459e-8042-d1e60387ec2e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7cf4af2-0b25-4d17-8184-9ce6d6c930a1"",
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
                    ""id"": ""95c4ceda-b223-4ca9-b672-9551b7281ca8"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d74da690-15dd-4eae-b844-1b45557a904f"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundInput
        m_GroundInput = asset.FindActionMap("GroundInput", throwIfNotFound: true);
        m_GroundInput_Move = m_GroundInput.FindAction("Move", throwIfNotFound: true);
        m_GroundInput_Sprint = m_GroundInput.FindAction("Sprint", throwIfNotFound: true);
        m_GroundInput_RotateCamera = m_GroundInput.FindAction("RotateCamera", throwIfNotFound: true);
        m_GroundInput_Attack = m_GroundInput.FindAction("Attack", throwIfNotFound: true);
        m_GroundInput_Jump = m_GroundInput.FindAction("Jump", throwIfNotFound: true);
        m_GroundInput_Crouch = m_GroundInput.FindAction("Crouch", throwIfNotFound: true);
        m_GroundInput_Prone = m_GroundInput.FindAction("Prone", throwIfNotFound: true);
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

    // GroundInput
    private readonly InputActionMap m_GroundInput;
    private IGroundInputActions m_GroundInputActionsCallbackInterface;
    private readonly InputAction m_GroundInput_Move;
    private readonly InputAction m_GroundInput_Sprint;
    private readonly InputAction m_GroundInput_RotateCamera;
    private readonly InputAction m_GroundInput_Attack;
    private readonly InputAction m_GroundInput_Jump;
    private readonly InputAction m_GroundInput_Crouch;
    private readonly InputAction m_GroundInput_Prone;
    public struct GroundInputActions
    {
        private @GameInput m_Wrapper;
        public GroundInputActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GroundInput_Move;
        public InputAction @Sprint => m_Wrapper.m_GroundInput_Sprint;
        public InputAction @RotateCamera => m_Wrapper.m_GroundInput_RotateCamera;
        public InputAction @Attack => m_Wrapper.m_GroundInput_Attack;
        public InputAction @Jump => m_Wrapper.m_GroundInput_Jump;
        public InputAction @Crouch => m_Wrapper.m_GroundInput_Crouch;
        public InputAction @Prone => m_Wrapper.m_GroundInput_Prone;
        public InputActionMap Get() { return m_Wrapper.m_GroundInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundInputActions set) { return set.Get(); }
        public void SetCallbacks(IGroundInputActions instance)
        {
            if (m_Wrapper.m_GroundInputActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnMove;
                @Sprint.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnSprint;
                @RotateCamera.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnRotateCamera;
                @Attack.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnAttack;
                @Jump.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnCrouch;
                @Prone.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnProne;
                @Prone.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnProne;
                @Prone.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnProne;
            }
            m_Wrapper.m_GroundInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Prone.started += instance.OnProne;
                @Prone.performed += instance.OnProne;
                @Prone.canceled += instance.OnProne;
            }
        }
    }
    public GroundInputActions @GroundInput => new GroundInputActions(this);
    public interface IGroundInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnProne(InputAction.CallbackContext context);
    }
}
