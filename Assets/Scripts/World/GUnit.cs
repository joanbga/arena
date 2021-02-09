public class GUnit : GObject
{
    protected virtual void Awake()
    {
        ObjectType += (int)GObjectType.GUnit;
        name = "GUnit";
    }
}
