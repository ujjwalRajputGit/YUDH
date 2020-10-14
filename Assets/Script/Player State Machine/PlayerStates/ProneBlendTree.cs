using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProneBlendTree : IPlayerState {
    public void Start() {
        Player.Animator.SetBool("IsProne", true);
    }

    public void Update() {
    }
    public void FixedUpdate() {
        Movement();
        AnimationController();
    }

    public bool StateCompleted() {
        return false;
    }

    public void OnExit() {
        Player.Animator.SetBool("IsProne", false);
    }
    private void AnimationController() {
        Player.Animator.SetFloat("VelocityX", Input.GetAxis.x);
        Player.Animator.SetFloat("VelocityZ", Input.GetAxis.z);
    }
    private void Movement() {
        Vector3 move = Player.PlayerObject.transform.right * Input.GetAxis.x + Player.PlayerObject.transform.forward * Input.GetAxis.z;
        if (Input.GetAxis.x != 0 || Input.GetAxis.z != 0) {
            Player.Rigidbodye.velocity = move * 4f;
        }
    }

}
