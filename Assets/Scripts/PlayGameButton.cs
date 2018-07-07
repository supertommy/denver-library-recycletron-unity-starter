using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGameButton : MonoBehaviour 
{
	[SerializeField]
	private Button playButton;

	private void Start() 
	{
		playButton.onClick.AddListener(HandleClick);
	}

	private void OnDestroy()
	{
		playButton.onClick.RemoveAllListeners();
	}

	private void HandleClick()
	{
		SceneManager.LoadScene("Game");
	}
}
