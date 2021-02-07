using UnityEngine;

/// <summary>
/// This class contains the function to call when play button is pressed
/// </summary>

public class LoadScene : MonoBehaviour
{
	public LoadEventChannelSO onLoadEvent;
	public GameSceneSO[] locationsToLoad;
	public bool showLoadScreen;

	public void LoadSceneAction()
	{
		onLoadEvent.RaiseEvent(locationsToLoad, showLoadScreen);
	}
}
