using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalInput, forwardInput;
    private float speed = 8f;
    private float rotationSpeed = 100f;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalInput);
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput); 
    }
}
