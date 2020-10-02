using UnityEngine;

public class BulletTest : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float time = 10;
    void Start()
    {
        //rb.AddForce(Vector3.back * force, ForceMode.Impulse);
        rb.velocity = Vector3.back * force;
        Destroy(gameObject, time);
    }

    private void Update() {
        //Debug.Log(rb.velocity.z);
    }

    
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Cdamage"+ collision.gameObject.name);
    }

}
