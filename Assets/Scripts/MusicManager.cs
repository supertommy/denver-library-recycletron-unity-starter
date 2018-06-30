using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour 
{
	[SerializeField]
	private AudioClip titleMusic;

	[SerializeField]
	private AudioClip gameMusic;

	[SerializeField]
	private AudioClip gameOverMusic;

	[SerializeField]
	private AudioSource musicSource;

	private void Start()
	{
		Scene currentScene = SceneManager.GetActiveScene();

		switch (currentScene.name)
		{
			case "Game":
				musicSource.clip = gameMusic;
				break;

			case "GameOver":
				musicSource.clip = gameOverMusic;
				break;

			case "TitleScreen":
				musicSource.clip = titleMusic;
				break;
		}

		if (musicSource.clip == null)
		{
			return;
		}

		musicSource.Play();
	}
}
