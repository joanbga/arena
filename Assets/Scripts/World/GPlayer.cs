/// <summary>
/// This is a player that is controlled by another person. Movement and actions infos will be passed from network.
/// </summary>
public class GPlayer : GUnit
{
    protected override void Awake()
    {
        base.Awake();
        ObjectType += (int)GObjectType.GPlayer;
        name = "GPlayer";
    }
}
