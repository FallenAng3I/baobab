using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [field: SerializeField] public float JumpForce { get; private set; }
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float movementSpeed;

    public Rigidbody Rb { get; private set; }

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        Rb.MovePosition(Rb.position + direction * movementSpeed * Time.fixedDeltaTime);
    }

    public void ApplyJump()
    {
        if (IsGrounded())
        {
            Rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }

    public void Rotate(float horizontalInput)
    {
        float rotationAmount = horizontalInput * rotationSpeed * Time.fixedDeltaTime;
        transform.Rotate(0, rotationAmount, 0);
    }
}