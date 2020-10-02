using UnityEngine;
using UnityEngine.InputSystem;

public class FireTest : MonoBehaviour
{

    PlayerInput playerInput;
    public Transform bullet;

    private void Awake() {
        playerInput = new PlayerInput();
        playerInput.GroundInput.Fire.performed += FireBullet;
    }
    void FireBullet (InputAction.CallbackContext context) {

    }

    private void FixedUpdate() {
        if (playerInput.GroundInput.Fire.ReadValue<float>() == 1f) {
            Instantiate(bullet, transform.position, bullet.rotation);
        }
        
    }

    private void OnEnable() {
        playerInput.Enable();
    }

    private void OnDisable() {
        playerInput.Disable();
    }

}
