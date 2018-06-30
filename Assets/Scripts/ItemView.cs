using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ItemView : MonoBehaviour 
{
	private enum ItemState
	{
		FALLING,
		SELECTED,
		FLYING_TO_RECYCLE
	}

	public ItemSpawner.ItemType itemType;

	private SpriteRenderer sprite;

	private Rigidbody2D body2D;

	private ItemState state;

	private void Start() 
	{
		state = ItemState.FALLING;

		body2D = GetComponent<Rigidbody2D>();

		body2D.angularVelocity = Random.Range(-100f, 100f);

		sprite = GetComponentInChildren<SpriteRenderer>();

		GameStateManager.instance.onScoreChanged.AddListener(HandleScoreChanged);

		HandleScoreChanged();
	}

	private void OnDestroy()
	{
		GameStateManager.instance.onScoreChanged.RemoveListener(HandleScoreChanged);
	}
	
	private void Update() 
	{
		if (state != ItemState.FALLING)
		{
			return;
		}

		if (transform.position.y < -8.0f)
		{
			if (itemType == ItemSpawner.ItemType.RECYCLE)
			{
				// TODO: handle recycles that player missed

				/*
				GetComponent<Collider2D>().enabled = false;

				if (sprite != null)
				{
					sprite.color = Color.grey;
				}

				gameObject.AddComponent<FlyToRecycleBinComponent>()

				StartCoroutine(LoseLifeWithDelay());
				 */

				state = ItemState.FLYING_TO_RECYCLE;
			}
			else
			{
				Destroy(gameObject);
			}
		}
	}

	private void HandleScoreChanged()
	{
		// TODO: increase difficulty as player progresses

		/* 
		// adjust speed at which items fall based on score to make game harder
		// as player progresses
		int score = GameStateManager.instance.score;

		float percent = score / 10000.0f;

		body2D.gravityScale =  Mathf.Max(percent, 0.2f);
		 */
	}

	public void OnSelected()
	{
		// TODO: respond to player clicking on an item

		/*
		state = ItemState.SELECTED;

		// turn off collisions
		GetComponent<Collider2D>().enabled = false;
		
		if (itemType == ItemSpawner.ItemType.GARBAGE)
		{
			if (sprite != null)
			{
				sprite.color = Color.red;
			}

			LoseLife();

			return;
		}

		// animate to side of screen
		gameObject.AddComponent<FlyToRecycleBinComponent>();

		state = ItemState.FLYING_TO_RECYCLE;

		GameStateManager.instance.AddPoints(100);

		SfxManager.instance.Play("DM-CGS-07");
		*/
	}

	private void LoseLife()
	{
		GameStateManager.instance.DecrementLife();

		//SfxManager.instance.Play("DM-CGS-25");

		// TODO: handle showing GameOver screen when reach 0 lives

		/*
		if (GameStateManager.instance.lives <= 0)
		{
			// GAMEOVER
			SceneManager.LoadScene("GameOver");
		}
		 */
	}

	private IEnumerator LoseLifeWithDelay(float secs=0.25f)
	{
		yield return new WaitForSeconds(secs);

		LoseLife();
	}
}
