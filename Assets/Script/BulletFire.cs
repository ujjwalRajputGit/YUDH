using UnityEngine;
using UnityEngine.InputSystem;

public class BulletFire : MonoBehaviour {

#pragma warning disable 0649
    [SerializeField] InputReader inputReader;

    [SerializeField] Transform BulletPrefab;
    [SerializeField] Camera mainCamera;
    [SerializeField] Transform gunPosition;
#pragma warning restore 0649


    private void FireBullet() {
        Vector3 position = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Instantiate(BulletPrefab, position, transform.rotation);
    }

    private void OnEnable() => inputReader.attackEvent += FireBullet;
    private void OnDisable() => inputReader.attackEvent -= FireBullet;


}