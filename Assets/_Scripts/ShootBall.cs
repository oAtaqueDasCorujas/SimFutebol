using UnityEngine;
using System.Collections;

public class ShootBall : MonoBehaviour 
{
	void Shoot(GameObject ball, float m_shootforce)
	{
		int r = Random.Range(0, 5);
		float m_angle = 0;

		if (r <=2)
			m_angle = Random.Range(-0.2f, 0.2f);
		else
			 m_angle = Random.Range(-0.8f, 0.8f);
		
		ball.GetComponent<Ball>().m_direction.x = Mathf.Cos(m_angle);
		ball.GetComponent<Ball>().m_direction.z = Mathf.Sin(m_angle);
	}
}
