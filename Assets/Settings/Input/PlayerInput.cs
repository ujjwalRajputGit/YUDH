// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""GroundInput"",
            ""id"": ""f73954b9-5272-48b2-8dbc-94a8dc252128"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
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
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""fd65f72a-3170-47da-987f-676f69b678d4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""eeec160a-5136-4272-836d-3a253d927a44"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Camera"",
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
                    ""action"": ""Fire"",
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
        m_GroundInput_Movement = m_GroundInput.FindAction("Movement", throwIfNotFound: true);
        m_GroundInput_Sprint = m_GroundInput.FindAction("Sprint", throwIfNotFound: true);
        m_GroundInput_Camera = m_GroundInput.FindAction("Camera", throwIfNotFound: true);
        m_GroundInput_Fire = m_GroundInput.FindAction("Fire", throwIfNotFound: true);
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
    private readonly InputAction m_GroundInput_Movement;
    private readonly InputAction m_GroundInput_Sprint;
    private readonly InputAction m_GroundInput_Camera;
    private readonly InputAction m_GroundInput_Fire;
    public struct GroundInputActions
    {
        private @PlayerInput m_Wrapper;
        public GroundInputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GroundInput_Movement;
        public InputAction @Sprint => m_Wrapper.m_GroundInput_Sprint;
        public InputAction @Camera => m_Wrapper.m_GroundInput_Camera;
        public InputAction @Fire => m_Wrapper.m_GroundInput_Fire;
        public InputActionMap Get() { return m_Wrapper.m_GroundInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundInputActions set) { return set.Get(); }
        public void SetCallbacks(IGroundInputActions instance)
        {
            if (m_Wrapper.m_GroundInputActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnMovement;
                @Sprint.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnSprint;
                @Camera.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnCamera;
                @Fire.started -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_GroundInputActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_GroundInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public GroundInputActions @GroundInput => new GroundInputActions(this);
    public interface IGroundInputActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
