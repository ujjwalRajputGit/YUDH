using UnityEngine;

public class IdleJumpLanding : IPlayerState {

    AnimatorStateInfo stateInfo;
    float transitionTiming;
    bool isComplete = false;


    public IdleJumpLanding(float transitionTiming) {
        this.transitionTiming = transitionTiming;
    }

    public void Start() {
        Player.Animator.SetBool("ToLanding", true);  
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
        return isComplete;
    }

    public void OnExit() {
        Player.Animator.SetBool("ToLanding", false);
        Player.IsJumping = false;
        Input.JumpKeyPressed = false;
    }
}
