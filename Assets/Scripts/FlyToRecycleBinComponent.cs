using UnityEngine;

public class FlyToRecycleBinComponent : MonoBehaviour 
{
	private readonly Vector3 recycleBinPosition = new Vector3(-5.98f, -2.41f, 0);

	private CRSpline spline;

	private float accumulatedTime;

	private Vector3 startingScale;

	private float startingAlpha;

	private SpriteRenderer sprite;

	private void Start() 
	{
		sprite = GetComponentInChildren<SpriteRenderer>();

		Vector3[] points = new Vector3[] {
			new Vector3(0, Random.Range(-30.0f, -20.0f), 0),
			transform.position,
			recycleBinPosition,
			recycleBinPosition + new Vector3(Random.Range(-15.0f, 15.0f), -20.0f, 0)
		};

		spline = new CRSpline(points);

		startingScale = transform.localScale;
		startingAlpha = sprite.color.a;
	}
	
	private void Update() 
	{
		accumulatedTime += Time.deltaTime;

		float t = accumulatedTime / 0.5f;

		// move in a spline
		Vector3 pos = spline.Interpolate(t);

		transform.position = pos;

		// shrink as it approaches destination
		float scaleX = Linear(startingScale.x, startingScale.x * 0.3f, t);
		float scaleY = Linear(startingScale.y, startingScale.x * 0.3f, t);

		transform.localScale = new Vector3(scaleX, scaleY, startingScale.z);

		// fade out as approaches destination
		float alpha = Linear(startingAlpha, 0.5f, t);

		Color newColor = sprite.color;

		newColor.a = alpha;

		sprite.color = newColor;

		if (t >= 1.0f)
		{
			Destroy(gameObject);
		}
	}

	private float Linear(float start, float target, float v)
	{
		return (start * (1.0f - v)) + (target * v);
	}
}
