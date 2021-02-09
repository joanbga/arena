using UnityEngine;

/// <summary>
/// GObject is the base class for interactable objects in the world.
/// This can be a simple object to pickup, an Unit, A Player or a LocalPlayer
/// </summary>
public abstract class GObject : MonoBehaviour
{
    public enum GObjectType
    {
        GUnit = 1,
        GPlayer = 2,
        GLocalPlayer = 4,
        GGameObject = 8
    }

    public int ObjectType
    {
        get;
        protected set;
    }

    public new string name {
        get;
        protected set;
    }
}
