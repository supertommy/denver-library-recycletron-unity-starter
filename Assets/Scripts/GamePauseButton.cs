using UnityEngine;

public class GamePauseButton : MonoBehaviour 
{
	[SerializeField]
	private GameObject pauseCanvas;

	private void Start() 
	{
		
	}

	public void HandlePause()
	{
		Instantiate(pauseCanvas);
	}
}
