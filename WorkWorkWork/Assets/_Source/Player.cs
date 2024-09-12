using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [field:SerializeField] public float JumpForce { get; private set; }
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float movementSpeed;

    public Rigidbody Rb { get; private set; }

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
    }
}
