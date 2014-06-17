using System;
using UnityEngine;

public class FollowBall : AbstractBehaviour 
{
	public override void Act()
	{
		Vector3 direction = (owner.ball.transform.position - transform.position).normalized;
		owner.body.Move(direction);
		//Debug.Log("Moving to Ball");
	}

	public override bool Think()
	{
		if (Vector3.Distance(owner.ball.transform.position, transform.position) <= 0.1f)
			return false;
		return true;
	}
}
