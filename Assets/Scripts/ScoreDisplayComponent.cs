using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayComponent : MonoBehaviour 
{
	private const string scoreFormat = "SCORE: {0:N0}";

	[SerializeField]
	private Text scoreLabel;
	
	private void Start() 
	{
		GameStateManager.instance.onScoreChanged.AddListener(HandleScoreChanged);

		HandleScoreChanged();
	}

	private void HandleScoreChanged()
	{
		scoreLabel.text = string.Format(scoreFormat, GameStateManager.instance.score);
	}

}
