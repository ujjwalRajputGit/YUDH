using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;


public class InputReader : MonoBehaviour, GameInput.IGroundInputActions {

    public UnityAction attackEvent;
    public UnityAction jumpEvent;
    public UnityAction crouchEvent;
    public UnityAction<float> sprintEvent;
    public UnityAction<Vector2> moveEvent;
    public UnityAction<Vector2> rotateCameraEvent;

    GameInput gameInput;

    private void OnEnable() {
        if (gameInput == null) {
            gameInput = new GameInput();
            gameInput.GroundInput.SetCallbacks(this);
        }
        gameInput.GroundInput.Enable();
    }

    private void OnDisable() {
        gameInput.GroundInput.Disable();
    }

    public void OnAttack(InputAction.CallbackContext context) {
        if (attackEvent != null
            && context.phase == InputActionPhase.Started)
            attackEvent.Invoke();
    }

    public void OnMove(InputAction.CallbackContext context) {
        if (moveEvent != null) {
            moveEvent.Invoke(context.ReadValue<Vector2>());
        }
    }

    public void OnRotateCamera(InputAction.CallbackContext context) {
        if (rotateCameraEvent != null) {
            rotateCameraEvent.Invoke(context.ReadValue<Vector2>());
        }
    }

    public void OnSprint(InputAction.CallbackContext context) {
        if (sprintEvent != null) {
           if(context.phase == InputActionPhase.Started)
            sprintEvent.Invoke(context.ReadValue<float>());
            else if(context.phase == InputActionPhase.Performed)
            sprintEvent.Invoke(context.ReadValue<float>());
        }
    }

    public void OnJump(InputAction.CallbackContext context) {
        if (jumpEvent != null
            && context.phase == InputActionPhase.Started)
            jumpEvent.Invoke();
    }

    public void OnCrouch(InputAction.CallbackContext context) {
        if (crouchEvent != null)
            crouchEvent.Invoke();
    }
}
