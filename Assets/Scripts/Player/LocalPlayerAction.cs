using UnityEngine;

public class LocalPlayerAction : MonoBehaviour
{
    [SerializeField] InputReader _inputReader;
    [SerializeField] CastSpellChannelSO castSpellChannel;

    private void OnEnable()
    {
        _inputReader.useSpellEvent += UseSpell;
    }

    private void OnDisable()
    {
        _inputReader.useSpellEvent -= UseSpell;
    }

    private void UseSpell(int n)
    {
        if (castSpellChannel)
        {
            castSpellChannel.RaiseEvent(gameObject, null, n);
        }
    }
}
