public class GPlayer : GUnit
{
    protected override void Awake()
    {
        base.Awake();
        ObjectType += (int)GObjectType.GPlayer;
        name = "GPlayer";
    }
}
