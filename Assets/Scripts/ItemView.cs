using UnityEngine;
using System.Collections;

public class ItemView : MonoBehaviour 
{
	private enum ItemState
	{
		FALLING,
		SELECTED,
		FLYING_TO_RECYCLE
	}

	[HideInInspector]
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

		HandleScoreChanged();
	}

	private void OnDestroy()
	{
		
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
	}

	public void OnSelected()
	{
		// TODO: respond to player clicking on an item
	}
}
