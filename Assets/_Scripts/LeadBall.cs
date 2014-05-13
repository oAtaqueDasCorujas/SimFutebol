using UnityEngine;
using System.Collections;

public class LeadBall : MonoBehaviour 
{
	void CarryBall(GameObject ball, GameObject goal)
	{
		Vector3 ball_direction = (goal.transform.position - ball.transform.position).normalized;
		ball.GetComponent<Ball>().m_direction.x = ball_direction.x;
		ball.GetComponent<Ball>().m_direction.z = ball_direction.z;
	}
}
