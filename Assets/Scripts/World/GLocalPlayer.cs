public class GLocalPlayer : GPlayer
{
    protected override void Awake()
    {
        base.Awake();
        ObjectType += (int)GObjectType.GLocalPlayer;
        name = "GLocalPlayer";
    }
}
