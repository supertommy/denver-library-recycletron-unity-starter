using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitleScreenButton : MonoBehaviour 
{
	public void Load()
	{
		SceneManager.LoadScene("TitleScreen");
	}
}
