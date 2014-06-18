using UnityEngine;
using System.Collections;

public class ShootBall : AbstractBehaviour 
{
	public override void Act()
	{
		/*Rand para setar angulo de direção do chute
		 *ao gol*/
		int r = Random.Range(0, 5);
		float angle = 0;

		if (r <= 2)
			angle = Random.Range(-0.2f, 0.2f);
		else
			angle = Random.Range(-0.8f, 0.8f);

		//Passado angulo de direção
		owner.ball.GetComponent<Ball>().mvec3_direction.x = Mathf.Cos(angle);
		owner.ball.GetComponent<Ball>().mvec3_direction.y = Mathf.Sin(angle);
		
		//Passado força do chute
		if (owner.myTeam == Team.Red)
			owner.ball.GetComponent<Ball>().mf_impulse = owner.body.m_shootforce;
		else
			owner.ball.GetComponent<Ball>().mf_impulse = -owner.body.m_shootforce;

		//Debug.Log("Shooting Ball");
	}

	public override bool Think()
	{
		/*Se a distancia a até a bola for menor que
			que a distancia minima de ação da bola*/
		if (Vector3.Distance(owner.ball.transform.position, transform.position) 
					< owner.body.m_ballaction &&
				Vector3.Distance(owner.goaltoscore.transform.position, transform.position)
					< owner.body.m_shootdistance)
			return true;
		return false;
	}
}
