using UnityEngine;

public class PlayerMovement
{
    public void Jump(float jumpForce, Rigidbody rb)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void Move(Vector3 direction, float movementSpeed, Rigidbody rb)
    {
        if (direction != Vector3.zero)
        {
            rb.MovePosition(rb.position + direction * (movementSpeed * Time.fixedDeltaTime));
        }
    }

    public void Rotate(float horizontalInput, float rotationSpeed, Transform playerTransform)
    {
        if (horizontalInput != 0)
        {
            float rotationAmount = horizontalInput * rotationSpeed * Time.fixedDeltaTime;
            playerTransform.Rotate(0, rotationAmount, 0);
        }
    }
}