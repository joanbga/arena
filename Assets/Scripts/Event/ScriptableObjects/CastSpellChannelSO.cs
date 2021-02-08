using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Cast Spell Event Channel")]
public class CastSpellChannelSO : ScriptableObject
{
	public UnityAction<GameObject, GameObject, int> OnCastSpell;

	public void RaiseEvent(GameObject caster, GameObject target, int buttonNumber)
	{
		if (OnCastSpell != null)
		{
			OnCastSpell.Invoke(caster, target, buttonNumber);
		}
	}
}
