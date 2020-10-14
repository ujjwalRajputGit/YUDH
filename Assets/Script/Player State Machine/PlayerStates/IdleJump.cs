using UnityEngine;

public class IdleJump : IPlayerState {

    float jumpForce;
    bool applyMovement = true;
    public IdleJump(float jumpForce) {
        this.jumpForce = jumpForce;
    }
    public void Start() {
        Player.Animator.SetBool("ToJump", true);
        Jump();
    }
    public void Update() {

    }

    public void FixedUpdate() {
        AirMovement();
    }
    public void OnExit() {
        Player.Animator.SetBool("ToJump", false);
    }
    public bool StateCompleted() {
        return false;
    }

    void Jump() {
        // Player.Rigidbodye.AddForce(Player.PlayerObject.transform.up * jumpForce,ForceMode.Impulse);
        Player.Rigidbodye.velocity = Player.PlayerObject.transform.up * jumpForce;
    }

    private void AirMovement() {
        Vector3 move = Player.PlayerObject.transform.right * Input.GetAxis.x
                       + Player.PlayerObject.transform.forward * Input.GetAxis.z;
        if (applyMovement) {
            if (Input.GetAxis.x != 0 || Input.GetAxis.z != 0) {
                Player.Rigidbodye.velocity = move * 1.2f;
                applyMovement = false;
            }
        }
    }
}