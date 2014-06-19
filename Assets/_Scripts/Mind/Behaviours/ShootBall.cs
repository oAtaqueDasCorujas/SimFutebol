using UnityEngine;
using System.Collections;

public class ShootBall : AbstractBehaviour
{
	public override void Act()
	{
		//Debug.Log("Shooting Ball");

		//alterando direção entre o jogador e o gol
		Vector3 t_direction = (owner.goaltoscore.transform.position - transform.position).normalized;
		t_direction = new Vector3(t_direction.x * Mathf.Cos(RandomizeAngle()),
															Mathf.Sin(RandomizeAngle()),
															0.0f);
		//Passado angulo de direção
		owner.ball.GetComponent<Ball>().mvec3_direction.x = t_direction.x;
		owner.ball.GetComponent<Ball>().mvec3_direction.y = t_direction.y;

		//Passado força do chute
		owner.ball.GetComponent<Ball>().mf_impulse = owner.body.m_shootforce;

		//Debug.Log("Shooting Ball");
		Debug.Log(t_direction);
	}

	public override bool Think()
	{
		//Debug.Log("How i shoot?");
		/*Se a distancia a até a bola for menor que
			que a distancia minima de ação da bola*/
		if (Vector3.Distance(owner.ball.transform.position, transform.position)
					<= owner.body.m_ballaction)
			if (Vector3.Distance(owner.goaltoscore.transform.position,
						transform.position) <= owner.body.m_shootdistance)
			{
				//Debug.Log("Now i can shoot");
				return true;
			}
		//Debug.Log("I still can't shoot: " + owner.body.m_shootdistance);
		return false;
	}

	/*Rand para setar angulo de direção do chute
	 *ao gol*/
	public float RandomizeAngle()
	{
		int r = Random.Range(0, 5);
		float angle = 0;

		switch (r)
		{
			case(0):
				{
					angle = -0.4f;
					break;
				}
			case(1):
				{
					angle = -0.2f;
					break;
				}
			case(2):
			case(3):
				{
					angle = 0.2f;
					break;
				}
			case(4):
			case(5):
				{
					angle = 0.4f;
					break;
				}
			default:
				{
					angle = 0.0f;
					break;
				}
		}

		return angle;
	}
}
