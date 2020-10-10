using UnityEngine;
public class IdleJumpPrep : IPlayerState {
    AnimatorStateInfo stateInfo;
    float transitionTiming;
    bool isComplete = false;

    public IdleJumpPrep(float transitionTiming) {
        this.transitionTiming = transitionTiming;
    }

    public void Start() {
        Player.Animator.SetBool("IsJumping", true);
    }

    public void Update() {
        stateInfo = Player.Animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.normalizedTime >= transitionTiming) {
            isComplete = true;
        }
    }

    public void FixedUpdate() {

    }
    public void OnExit() {

    }

    public bool StateCompleted() {
        return isComplete;
    }
}