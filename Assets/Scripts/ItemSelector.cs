using UnityEngine;

public class ItemSelector : MonoBehaviour 
{
	private void Update()
	{
		if (!Input.GetMouseButtonDown(0))
		{
			return;
		}

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		int mask = LayerMask.GetMask("Selectable");

		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 100.0f, mask);

		if (hit.collider == null)
		{
			return;
		}

		ItemView item = hit.collider.gameObject.GetComponent<ItemView>();

		item.OnSelected();
	}
}
