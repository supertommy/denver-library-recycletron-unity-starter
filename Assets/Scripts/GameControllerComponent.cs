using UnityEngine;

public class GameControllerComponent : MonoBehaviour 
{
	public const float GRAVITY = -9.8f;

	private void Awake() 
	{
		Physics.gravity = new Vector3(0, GRAVITY, 0);

		GameStateManager.instance.SetLives(3);
		GameStateManager.instance.SetScore(0);
	}
}
