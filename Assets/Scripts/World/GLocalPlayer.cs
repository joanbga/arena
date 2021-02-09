/// <summary>
/// Player controller by the current client. His movement and actions will be sent to the network.
/// </summary>
public class GLocalPlayer : GPlayer
{
    protected override void Awake()
    {
        base.Awake();
        ObjectType += (int)GObjectType.GLocalPlayer;
        name = "GLocalPlayer";
    }
}
