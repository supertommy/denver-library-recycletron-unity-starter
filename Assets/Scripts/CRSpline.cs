using UnityEngine;
using System;

public class CRSpline
{
	private Vector3[] points;

	private static Vector3[] From(Vector2[] pts)
	{
		Vector3[] ptsVec3 = new Vector3[pts.Length];
		for (int i = 0; i < pts.Length; ++i)
		{
			Vector2 vec2 = pts[i];
			ptsVec3[i] = new Vector3(vec2.x, vec2.y, 0);
		}
		return ptsVec3;
	}

	public CRSpline(params Vector3[] pts)
	{
		points = new Vector3[pts.Length];
		Array.Copy(pts, points, pts.Length);
	}

	public CRSpline(params Vector2[] pts) : this(From(pts))
	{

	}

	public Vector3 Interpolate(float t)
	{
		int numSections = points.Length - 3;
		int currPt = Mathf.Min(Mathf.FloorToInt(t * (float)numSections), numSections - 1);

		Vector3 p0 = points[currPt];
		Vector3 p1 = points[currPt + 1];
		Vector3 p2 = points[currPt + 2];
		Vector3 p3 = points[currPt + 3];

		// catmull-rom spline algorithm: http://www.mvps.org/directx/articles/catmull/
		return 0.5f * ((2 * p1) +
						(-p0 + p2) * t +
						(2 * p0 - 5 * p1 + 4 * p2 - p3) * (t * t) +
						(-p0 + 3 * p1 - 3 * p2 + p3) * (t * t * t));
	}
}