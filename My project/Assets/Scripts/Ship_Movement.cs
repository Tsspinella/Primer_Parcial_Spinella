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

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * thrustForce * vertical * Time.deltaTime;
        transform.Rotate(Vector3.up, horizontal * Time.deltaTime * rotationSpeed);
    }
}