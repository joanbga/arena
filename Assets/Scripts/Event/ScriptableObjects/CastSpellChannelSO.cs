using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Cast Spell Event Channel")]
public class CastSpellChannelSO : ScriptableObject
{
	public UnityAction<GUnit, GUnit, int> OnCastSpell;

	public void RaiseEvent(GUnit caster, GUnit target, int buttonNumber)
	{
		if (OnCastSpell != null)
		{
			OnCastSpell.Invoke(caster, target, buttonNumber);
		}
	}
}
