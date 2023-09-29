using System.Runtime.CompilerServices;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public GameObject target;
    public float velocity;
    public float acceleration = 20;
    public float horizontal;
    public float vertical;
    public float thrustForce;
    public float rotationSpeed;
    public Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

       // transform.position += transform.forward * thrustForce * vertical * Time.deltaTime;
        rb.velocity = transform.forward * thrustForce * vertical * Time.deltaTime;
        transform.Rotate(Vector3.up, horizontal * Time.deltaTime * rotationSpeed);


    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + "colisiono con" + collision.collider.name);
    }
}