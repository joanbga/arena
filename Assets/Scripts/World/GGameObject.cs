public class GGameObject : GObject
{
    private void Awake()
    {
        ObjectType += (int)GObjectType.GGameObject;
        name = "GGameObject";
    }
}
