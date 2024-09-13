using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private Player player;
    private PlayerInvoker playerInvoker;

    private void Awake()
    {
        playerInvoker = new PlayerInvoker(player);
    }

    void Update()
    {
        ReadJump();
        ReadMovement();
    }

    private void ReadJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerInvoker.InvokeJump();
        }
    }

    private void ReadMovement()
    {
        Vector3 direction = Vector3.zero;
        
        if (Input.GetKey(KeyCode.W))
        {
            direction = player.transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = -player.transform.forward;
        }

        float horizontalInput = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }

        playerInvoker.InvokeMove(direction, horizontalInput);
    }
}