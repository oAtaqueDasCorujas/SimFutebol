using UnityEngine;
using System.Collections;

public class LeadBall : MonoBehaviour 
{
	void CarryBall(GameObject ball, Vector3 goal_position)
	{
		Vector3 ball_direction = (goal_position - ball.transform.position).normalized;
		ball.GetComponent<Ball>().mvec3_direction.x = ball_direction.x;
		ball.GetComponent<Ball>().mvec3_direction.z = ball_direction.z;
	}
}
