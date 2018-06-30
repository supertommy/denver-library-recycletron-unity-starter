using UnityEngine;

public class ItemSpawner : MonoBehaviour 
{
	public enum ItemType
	{
		GARBAGE,
		RECYCLE
	}

	public ItemView[] itemPrefabs;

	public float spawnFrequency = 0.1f;

	public ItemType itemType;
	
	private void Start() 
	{
		
	}

	private void Update()
	{
		float chance = Random.Range(0.0f, 1.0f);

		if (chance >= spawnFrequency)
		{
			return;
		}

		int idx = Random.Range(0, itemPrefabs.Length);

		ItemView item = Instantiate(itemPrefabs[idx]);
		item.itemType = itemType;

		float x = Random.Range(-1.0f, 8.0f);

		item.transform.position = new Vector3(x, gameObject.transform.position.y, 0);
		item.transform.SetParent(transform);

	}
}
