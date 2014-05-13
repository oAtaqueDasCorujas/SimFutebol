using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	void FollowBall(GameObject ball, float m_velocity)
	{
		Vector3 m_direction = (ball.transform.position - transform.position).normalized;
		transform.position = new Vector3(transform.position.x + (m_velocity * m_direction.x * Time.deltaTime),
																			transform.position.y,
																			transform.position.z + (m_velocity * m_direction.z * Time.deltaTime));
	}
}
