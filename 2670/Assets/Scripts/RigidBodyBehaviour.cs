using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyBehaviour : MonoBehaviour
{
    public float force;
    
    private Rigidbody rb;
    IEnumerator Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(force, 0, 0);
        yield return new WaitForSeconds(0.5f);
        rb.Sleep();
        yield return new WaitForSeconds(0.5f);
        rb.WakeUp();
        rb.AddForce(0, 300f, 0);
        StartCoroutine(Start());
    }
}