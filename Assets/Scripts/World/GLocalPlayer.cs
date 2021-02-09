using UnityEngine;

/// <summary>
/// Player controller by the current client. His movement and actions will be sent to the network.
/// </summary>
public class GLocalPlayer : GPlayer
{
    [SerializeField] InputReader _inputReader;

    private void OnEnable()
    {
        _inputReader.useSpellEvent += CastSpell;
    }

    private void OnDisable()
    {
        _inputReader.useSpellEvent -= CastSpell;
    }

    protected override void Awake()
    {
        base.Awake();
        ObjectType += (int)GObjectType.GLocalPlayer;
        name = "GLocalPlayer";
    }
}
