using UnityEngine;

public class PlayerMovement
{
    public void Jump(float jumpForce, Rigidbody rb)
    {
        Player player = rb.GetComponent<Player>();
        if (player != null)
        {
            player.ApplyJump();
        }
    }
}