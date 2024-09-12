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
        playerMovement.Jump(player.JumpForce, player.Rb);
    }
}