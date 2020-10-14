using UnityEngine;

public class PlayerMovement : MonoBehaviour {

#pragma warning disable 0649
    [SerializeField] private InputReader inputReader;
    [SerializeField] private float speed = 4.7f;
    [SerializeField] private float sprintSpeed = 6.3f;
    [Range(0, 1)]
    [SerializeField] private float decrement;
    [SerializeField] private float jumpForce;
    [SerializeField] private PlayerStateMachine PlayerStateMachine;
#pragma warning restore 0649

    private float moveX;
    private float moveZ;
    private bool controlsEnabled = true;
    private Rigidbody rb;
    private Animator animator;
    private bool isLeftShiftDown;

    AnimatorStateInfo info;
    string animationName;
    AnimatorClipInfo[] clipInfo;

    IdleJumpPrep idleJumpPrep;
    IdleJump idleJump;
    IdleJumpLanding idleJumpLanding;
    StandingBlendTree run;

    CrouchBlendTree crouch;
    ProneBlendTree prone;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        idleJumpPrep = new IdleJumpPrep(.8f);
        idleJump = new IdleJump(jumpForce);
        crouch = new CrouchBlendTree();
        prone = new ProneBlendTree();
        run = new StandingBlendTree(transform.right,
                transform.forward,
                rb,
                speed,
                gameObject);
        idleJumpLanding = new IdleJumpLanding(.9f);
    }

    private void Start() {
        PlayerStateMachine.ChangePlayerState(run);
        info = animator.GetCurrentAnimatorStateInfo(0);
        clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        animationName = animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;

    }
    private void Update() {
        if (Input.JumpKeyPressed && Input.GetAxis.x == 0 && Input.GetAxis.z == 0 && !Player.IsJumping) {
            // Debug.Break();
            PlayerStateMachine.ChangePlayerState(idleJumpPrep);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleJumpPrep")) {
            if (PlayerStateMachine.OnCurrentStateComplete()) {
                PlayerStateMachine.ChangePlayerState(new IdleJump(jumpForce));
            }
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleJump")) {
            if (Player.IsGrounded) {
                PlayerStateMachine.ChangePlayerState(idleJumpLanding);
            }
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleJumpLanding")) {
            if (PlayerStateMachine.OnCurrentStateComplete()) {
                PlayerStateMachine.ChangePlayerState(run);
            }
        }

        // if (Player.IsGrounded && !Input.JumpKeyPressed && !Player.IsJumping) {
        //     if (Input.CrouchKeyPressed) {
        //         PlayerStateMachine.ChangePlayerState(crouch);
        //     } else if (Input.ProneKeyPressed) {
        //         PlayerStateMachine.ChangePlayerState(prone);
        //     } else {
        //         PlayerStateMachine.ChangePlayerState(run);
        //     }
        // }
        Debug.Log("IsGrounded" + Player.IsGrounded);
        Debug.Log("jumpKey" + Input.JumpKeyPressed);
        // Debug.Log(Player.Rigidbodye.velocity);
        // Debug.Log(animationName);
        // Debug.Log(animator.GetCurrentAnimatorClipInfo(0)[0].clip.name);

    }
    private void FixedUpdate() {
        // Movement();
        // AnimationController();
        // Jump();
    }

    // void Jump() {
    //     if (Input.JumpKeyPressed && Player.IsGrounded) {
    //         Input.JumpKeyPressed = false;
    //         rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    //         animator.SetBool("IsJumping", true);
    //     }
    // }

    void Jump2() {
        if (Input.JumpKeyPressed && Player.IsGrounded) {
            Player.Rigidbodye.AddForce(Player.PlayerObject.transform.up * jumpForce, ForceMode.Impulse);
            // Debug.Log(Player.Rigidbodye.velocity.y);
            // Input.JumpKeyPressed = false;
        }
    }
    private void Movement() { //applying velocity to player.

        //if ((moveZ != 0 && moveX == 0) || (moveX != 0 && moveZ == 0)) {
        //    rb.velocity = move * velocity;
        //}

        //if (moveZ != 0 && moveX != 0) {
        //    rb.velocity = move * velocity * decrement;

        //}

        //Debug.Log(rb.velocity);
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        if (moveX != 0 || moveZ != 0) {
            if (isLeftShiftDown)
                rb.velocity = move * sprintSpeed;
            else
                rb.velocity = move * speed;
        }
    }

    // private void AnimationController() {
    //     if (isLeftShiftDown) {
    //         animator.SetFloat("VelocityX", moveX * 2f);
    //         animator.SetFloat("VelocityZ", moveZ * 2f);
    //     } else {
    //         animator.SetFloat("VelocityX", moveX);
    //         animator.SetFloat("VelocityZ", moveZ);
    //     }
    // }

    void IsLeftShiftDown(float isLeftShiftDown) {
        if (isLeftShiftDown > 0.5f) {
            this.isLeftShiftDown = true; //true when pressed, return 1 when presed, for safety we use > .5
        } else {
            this.isLeftShiftDown = false; // false when released, when release return 0
        }
    }

    private void Move(Vector2 move) { //method called by unityEvent.
        if (controlsEnabled) {
            moveX = move.x;
            moveZ = move.y;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        // Debug.Log("Player" + collision.gameObject.name);
    }
    private void OnEnable() { //adding ethod to unityEvent.
        inputReader.moveEvent += Move;
        inputReader.sprintEvent += IsLeftShiftDown;
    }
    private void OnDisable() { //removing method from unityEvent.
        inputReader.moveEvent -= Move;
        inputReader.sprintEvent -= IsLeftShiftDown;
    }
}
