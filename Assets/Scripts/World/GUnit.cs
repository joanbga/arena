using UnityEngine;

/// <summary>
/// Units are Non-player character (NPC).
/// This implementation should notbe used as this but by instanciating Player or LocalPlayer since this is a PvP only Game.
/// But we nerver know, si it exists...
/// </summary>
public class GUnit : GObject
{
    [SerializeField] CastSpellChannelSO castSpellChannel;
    protected virtual void Awake()
    {
        ObjectType += (int)GObjectType.GUnit;
        name = "GUnit";
    }

    public void CastSpell(int n)
    {
        if (castSpellChannel)
        {
            castSpellChannel.RaiseEvent(this, null, n);
        }
    }
}
