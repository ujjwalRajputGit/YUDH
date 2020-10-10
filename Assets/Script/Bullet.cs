using UnityEngine;

public class Bullet : MonoBehaviour {

#pragma warning disable 0649
    [SerializeField] Rigidbody rb;
    [SerializeField] float force = 1f;
    [SerializeField] float bulletSelfDestructionTime = 5f;
    [SerializeField] Transform BulletHolePrefab;

#pragma warning restore 0649

    private void Start() {
        //rb.AddForce(transform.eulerAngles * force, ForceMode.Impulse);
        // rb.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
        rb.velocity = transform.forward * force;
        Destroy(gameObject, bulletSelfDestructionTime);
    }

private void Update() {
    // Debug.Log(rb.velocity);
    // Debug.Log("z"+rb.velocity.z);
}
    private void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name);
        Instantiate(BulletHolePrefab,collision.contacts[0].point,Quaternion.LookRotation(collision.contacts[0].normal));
        Destroy(gameObject);
       
        Debug.Log(collision.collider.name);
        
    }

}
