using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyBehaviour : MonoBehaviour
{
    public float force;
    
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(force, Vector3.forward, 3f);
    }
    
}