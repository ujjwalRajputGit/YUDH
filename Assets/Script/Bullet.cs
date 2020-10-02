using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField] private Rigidbody rb;
    public float force = 1f;
    public float bulletSelfDestructionTime = 5f;
    void Start() {
        //rb.AddForce(transform.eulerAngles * force, ForceMode.Impulse);
        rb.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
        //rb.velocity = Vector3.up * force;
        Destroy(gameObject, bulletSelfDestructionTime);
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name);
    }

}
