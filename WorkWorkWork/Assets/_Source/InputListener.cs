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
    }

    private void ReadJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerInvoker.InvokeJump();
        }
    }
}