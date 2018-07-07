using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour 
{
	private static GameStateManager _instance;

	public static GameStateManager instance { 
		get {
			return _instance;
		}
	}

	public int lives {get; private set;}

	public int score {get; private set;}

	public UnityEvent onLoseLife {get; private set;}

	public UnityEvent onScoreChanged {get; private set;}

	private void Awake()
	{
		if (_instance != null)
		{
			Debug.LogWarning("Duplicate GameStateManager. Deleting...");

			Destroy(gameObject);

			return;
		}

		_instance = this;

		Application.runInBackground = true;

		lives = 3;

		onLoseLife = new UnityEvent();
		onScoreChanged = new UnityEvent();
	}

	private void OnDestroy()
	{
		if (onLoseLife != null)
		{
			onLoseLife.RemoveAllListeners();
		}

		if (onScoreChanged != null)
		{
			onScoreChanged.RemoveAllListeners();
		}
	}

	public void DecrementLife()
	{
		// TODO: implement DecrementLife
	}

	public void AddPoints(int points)
	{
		// TODO: implement AddPoints
	}

	public void SetLives(int newLives)
	{
		// TODO: implement SetLives
	}

	public void SetScore(int newScore)
	{
		// TODO: implement SetScore
	}

}
