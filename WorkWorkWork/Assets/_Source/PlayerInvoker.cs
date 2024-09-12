using UnityEngine;

public class PlayerInvoker
{
    private PlayerMovement playerMovement;
    private Player player;

    public PlayerInvoker(Player player)
    {
        playerMovement = new();
        this.player = player;
    }
}
