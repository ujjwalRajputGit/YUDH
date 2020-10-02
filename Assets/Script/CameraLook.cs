using UnityEngine.InputSystem;
using UnityEngine;
using Cinemachine;

public class CameraLook : MonoBehaviour
{
    PlayerInput playerInput;
    CinemachineFreeLook cinemachineFreeLook;

    public float mouseSensivityX = 1;
    public float mouseSensivityY = 1;


    private void Awake() {
        playerInput = new PlayerInput();  // script created by new input system
        cinemachineFreeLook = GetComponent<CinemachineFreeLook>();
        playerInput.GroundInput.Camera.performed += CameraDelta;
    }

    private void Start() {
        Cursor.visible = false;
    }

    void CameraDelta(InputAction.CallbackContext context) {
        Vector2 lookDelta = context.ReadValue<Vector2>();
        cinemachineFreeLook.m_XAxis.Value -= lookDelta.x * mouseSensivityX;

        float lookDeltaY = lookDelta.y / 100f;
        cinemachineFreeLook.m_YAxis.Value += lookDeltaY * mouseSensivityY;
    }

    
    private void OnEnable() => playerInput.GroundInput.Enable();

    private void OnDisable() => playerInput.GroundInput.Disable();
}
