using UnityEngine;
using UnityEngine.InputSystem;

public class BulletFire : MonoBehaviour {
    PlayerInput playerInput;
    [SerializeField] Transform BulletPrefab;
    [SerializeField] Camera mainCamera;

    private void Awake() {
        playerInput = new PlayerInput();
        playerInput.GroundInput.Fire.performed += FireBullet;
    }

    void FireBullet(InputAction.CallbackContext context) {
        Vector3 position = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Instantiate(BulletPrefab, position, transform.rotation);
    }



    private void OnEnable() => playerInput.Enable();
    private void OnDisable() => playerInput.Disable();


}