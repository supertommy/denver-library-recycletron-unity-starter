using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GamePauseCanvas : MonoBehaviour 
{
	[SerializeField]
	private Toggle audioToggle;

	[SerializeField]
	private Button resumeButton;

	[SerializeField]
	private Button quitButton;

	[SerializeField]
	private AudioMixer audioMixer;

	private void Awake()
	{
		// TODO: implement "pause" using timeScale

		//Time.timeScale = 0;
	}

	private void Start() 
	{
		// TODO: make sure toggle shows current state of audio

		/*
		float vol = 0;
		
		// get the current volume
		audioMixer.GetFloat("masterVolume", out vol);

		// set toggle to off if volume is already off
		if (vol <= -80)
		{
			audioToggle.isOn = false;
		}
		*/

		resumeButton.onClick.AddListener(HandleResume);
		quitButton.onClick.AddListener(HandleQuit);

		audioToggle.onValueChanged.AddListener(HandleAudioChanged);
	}

	private void OnDestroy()
	{
		resumeButton.onClick.RemoveAllListeners();
		quitButton.onClick.RemoveAllListeners();
	}

	private void HandleAudioChanged(bool isOn)
	{
		// TODO: turn off audio if on / turn on audio if off

		/*
		float vol = isOn ? 0 : -80;

		audioMixer.SetFloat("masterVolume", vol);
		 */
	}

	private void HandleResume()
	{
		// TODO: unpause and destroy the Pause menu gameobject

		/*
		Time.timeScale = 1;
		Destroy(gameObject);
		 */
	}

	private void HandleQuit()
	{
		// TODO: handle quite game: go back to TitleScreen
		
		/*
		SceneManager.LoadScene("TitleScreen");
		*/
	}
}
