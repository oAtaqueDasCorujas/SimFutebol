using UnityEngine;
using System.Collections;

public class ShootBall : AbstractBehaviour 
{
	public override void Act()
	{
		int r = Random.Range(0, 5);
		float angle = 0;

		if (r <= 2)
			angle = Random.Range(-0.2f, 0.2f);
		else
			angle = Random.Range(-0.8f, 0.8f);

		owner.ball.GetComponent<Ball>().mvec3_direction.x = Mathf.Cos(angle);
		owner.ball.GetComponent<Ball>().mvec3_direction.y = Mathf.Sin(angle);
		if (owner.myTeam == Team.Red)
			owner.ball.GetComponent<Ball>().mf_impulse = owner.body.m_shootforce;
		else
			owner.ball.GetComponent<Ball>().mf_impulse = -owner.body.m_shootforce;

		Debug.Log("Shooting Ball");
	}

	public override bool Think()
	{
		if (Vector3.Distance(owner.ball.transform.position, transform.position) < 0.1f)
			return true;
		return false;
	}
}
