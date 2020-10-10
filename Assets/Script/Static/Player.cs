using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

#pragma warning disable 0649
    [SerializeField] Collider boxCollider;
#pragma warning restore 0649

    static Rigidbody rigidbodye;
    static Animator animator;
    static GameObject playerObject;
    static Collider groundCollider;
    static bool isGrounded;

    static GameObject groundCheck;

    private void Awake() {
        rigidbodye = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        groundCollider = boxCollider;
        playerObject = gameObject;
    }

    public static Animator Animator { get => animator; }
    public static Rigidbody Rigidbodye { get => rigidbodye; }
    public static GameObject PlayerObject { get => playerObject; }
    public static bool IsGrounded { get => isGrounded; }
    public static Collider GroundCollider { get => groundCollider; }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag != "Player") {
            isGrounded = true;
            // Debug.Log("enter"+other);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag != "Player") {
            isGrounded = false;
            // Debug.Log("exit"+other);
        }
    }
}
