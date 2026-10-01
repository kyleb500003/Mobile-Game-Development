using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 15f;
    public float xBoundary = 2.5f; // how far left or right the car can go

    void Update()
    {
        float horizontalInput = Input.acceleration.x;

        if (Input.GetAxis("Horizontal") != 0)
        {
            horizontalInput = Input.GetAxis("Horizontal");
        }

        float xOffset = horizontalInput * moveSpeed * Time.deltaTime;
        float newXPosition = Mathf.Clamp(transform.position.x + xOffset, -xBoundary, xBoundary);

        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
    }
}
