using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour 
{
	private static SfxManager _instance;

	public static SfxManager instance {
		get {
			return _instance;
		}
	}

	[SerializeField]
	private AudioClip[] clips;

	[SerializeField]
	private AudioSource sfxSource;

	private Dictionary<string, AudioClip> clipsByName;

	private void Awake()
	{
		if (_instance != null)
		{
			Destroy(gameObject);
			return;
		}

		_instance = this;
	}

	private void Start() 
	{
		clipsByName = new Dictionary<string, AudioClip>();
		for (int i = 0; i < clips.Length; ++i)
		{
			AudioClip clip = clips[i];

			clipsByName.Add(clip.name, clip);
		}
	}

	public void Play(string name)
	{
		if (!clipsByName.ContainsKey(name))
		{
			return;
		}

		sfxSource.PlayOneShot(clipsByName[name]);
	}
}
