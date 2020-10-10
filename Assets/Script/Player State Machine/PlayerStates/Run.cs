using UnityEngine;
public class Run : IPlayerState {
    Vector3 transformRight;
    Vector3 transformForward;
    GameObject player;
    Rigidbody rb;
    float speed;
    public Run(Vector3 transformRight, Vector3 transformForward, Rigidbody rb, float speed, GameObject player) {
        this.transformRight = transformRight;
        this.transformForward = transformForward;
        this.rb = rb;
        this.speed = speed;
        this.player = player;
    }
    public void Start() {
        // Player.GroundCollider.enabled = false;
        Player.Animator.SetBool("IsJumping", false);
    }

    public void Update() {

    }

    public void FixedUpdate() {
        Movement();
        AnimationController();
    }

    public void OnExit() {
    }

    public bool StateCompleted() {
        return false;
    }

    private void AnimationController() {
        Player.Animator.SetFloat("VelocityX", Input.GetAxis.x);
        Player.Animator.SetFloat("VelocityZ", Input.GetAxis.z);
    }
    private void Movement() { //applying velocity to player.

        //if ((moveZ != 0 && moveX == 0) || (moveX != 0 && moveZ == 0)) {
        //    rb.velocity = move * velocity;
        //}

        //if (moveZ != 0 && moveX != 0) {
        //    rb.velocity = move * velocity * decrement;

        //}

        //Debug.Log(rb.velocity);
        Vector3 move = Player.PlayerObject.transform.right * Input.GetAxis.x + Player.PlayerObject.transform.forward * Input.GetAxis.z;
        if (Input.GetAxis.x != 0 || Input.GetAxis.z != 0) {
            rb.velocity = move * speed;
        }
    }

}