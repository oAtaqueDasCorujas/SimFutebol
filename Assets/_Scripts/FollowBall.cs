using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	void FollowBall(GameObject ball, float velocity)
	{
		Vector3 direction = (ball.transform.position - transform.position).normalized;
		transform.position = new Vector3(transform.position.x + (velocity * direction.x * Time.deltaTime),
																			transform.position.y,
																			transform.position.z + (velocity * direction.z * Time.deltaTime));
	}
}
