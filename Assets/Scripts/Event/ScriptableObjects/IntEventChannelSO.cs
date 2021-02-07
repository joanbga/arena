using UnityEngine.Events;
using UnityEngine;

/// <summary>
/// This class is used for Events that have an int argument.
/// Example: An event to catch a flag with the team ID as parameter
/// </summary>

[CreateAssetMenu(menuName = "Events/Int Event Channel")]
public class IntEventChannelSO : ScriptableObject
{
	public UnityAction<int> OnEventRaised;
	public void RaiseEvent(int value)
	{
		if (OnEventRaised != null)
			OnEventRaised.Invoke(value);
	}
}
