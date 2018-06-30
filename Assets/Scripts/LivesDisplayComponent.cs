using UnityEngine;
using UnityEngine.UI;

public class LivesDisplayComponent : MonoBehaviour 
{
	[SerializeField]
	private Text livesLabel;
	
	private void Start() 
	{
		Refresh();

		GameStateManager.instance.onLoseLife.AddListener(HandleLoseLife);
	}

	private void OnDestroy()
	{
		GameStateManager.instance.onLoseLife.RemoveListener(HandleLoseLife);
	}

	private void HandleLoseLife()
	{
		Refresh();
	}

	private void Refresh()
	{
		livesLabel.text = "LIVES: " + GameStateManager.instance.lives;
	}

}
