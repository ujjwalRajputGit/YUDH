using UnityEngine;

public class IdleJumpLanding : IPlayerState {

    AnimatorStateInfo stateInfo;
    float transitionTiming;
    bool isComplete = false;


    public IdleJumpLanding(float transitionTiming) {
        this.transitionTiming = transitionTiming;
    }

    public void Start() {
        // Player.GroundCollider.enabled = true;    
        Player.Animator.SetBool("IsGrounded", true);  
    }

    public void Update() {
        stateInfo = Player.Animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.normalizedTime >= transitionTiming) {
        isComplete = true; 
        }                
    }

    public void FixedUpdate() {
        
    }

    public bool StateCompleted() {
        Player.Animator.SetBool("IsJumping", false);
        return isComplete;
    }

    public void OnExit() {
        Player.Animator.SetBool("IsGrounded", false); 
        Input.JumpKeyPressed = false; 
    }
}
