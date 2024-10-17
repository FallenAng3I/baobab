using UnityEngine;

public class PlayerInvoker
{
    private PlayerMovement playerMovement;
    private Player player;

    public PlayerInvoker(Player player)
    {
        playerMovement = new PlayerMovement();
        this.player = player;
    }

    public void InvokeJump()
    {
        if (player.IsGrounded())
        {
            playerMovement.Jump(player.JumpForce, player.Rb);
        }
    }

    public void InvokeMove(Vector3 direction, float horizontalInput)
    {
        playerMovement.Move(direction, player.GetMovementSpeed(), player.Rb);
        playerMovement.Rotate(horizontalInput, player.GetRotationSpeed(), player.transform);
    }
}