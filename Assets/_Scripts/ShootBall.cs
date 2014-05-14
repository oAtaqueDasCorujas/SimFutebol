using UnityEngine;
using System.Collections;

public class ShootBall : MonoBehaviour 
{
	void Shoot(GameObject ball, float shootforce)
	{
		int r = Random.Range(0, 5);
		float angle = 0;

		if (r <=2)
			angle = Random.Range(-0.2f, 0.2f);
		else
			angle = Random.Range(-0.8f, 0.8f);
		
		ball.GetComponent<Ball>().mvec3_direction.x = Mathf.Cos(angle);
		ball.GetComponent<Ball>().mvec3_direction.z = Mathf.Sin(angle);
		ball.GetComponent<Ball>().mf_impulse = shootforce;
	}
}
