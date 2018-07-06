using UnityEngine;

public class GamePauseButton : MonoBehaviour 
{
	[SerializeField]
	private GameObject pauseCanvas;

	public void HandlePause()
	{
		Instantiate(pauseCanvas);
	}
}
