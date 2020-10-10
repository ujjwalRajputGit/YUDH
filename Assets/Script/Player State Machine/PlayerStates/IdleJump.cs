using UnityEngine;
    
public class IdleJump : IPlayerState {

    float jumpForce;
    public IdleJump(float jumpForce) {
        this.jumpForce = jumpForce;
    }
    public void Start() {
        Player.Animator.SetBool("JumpForce",true);
        Jump();
    }
    public void Update() {

    }

    public void FixedUpdate() {
    }
    public void OnExit() {
        Player.Animator.SetBool("JumpForce",false);
        // Player.Rigidbodye.velocity = Player.PlayerObject.transform.up * -Player.Rigidbodye.velocity.y;    
    }
    public bool StateCompleted() {
        return false;
    }

    void Jump() {
            // Player.Rigidbodye.AddForce(Player.PlayerObject.transform.up * jumpForce,ForceMode.Impulse);
            Player.Rigidbodye.velocity = Player.PlayerObject.transform.up * jumpForce;
    }
}