using UnityEngine;
using System.Collections;

public class PassBall : AbstractBehaviour 
{
	public override void Act()
	{
		/*força ou velocidade do toque da bola retirada da formula
		 (m*v^2)/2 = f*d 
		 A seguir eu escolhi isolar velocidade, mas é possivel
		 também fazer isolando força, tudo depende da forma
		 como iremos implementar a aceleração, impulso e 
		 velocidade da bola*/

		float shootforce, velocity = 0;
		//m_shootforce = Mathf.Sqrt(2 * 5f * Vector3.Distance(alvo.transform.position, transform.position)) + alvo.GetComponent<Test>().m_velocity*2;
		//m_shootforce = (Mathf.Pow(alvo.GetComponent<Test>().m_velocity, 2) * Vector3.Distance(alvo.transform.position, transform.position)) / 2;
		shootforce = Mathf.Sqrt(2 * 5 * Vector3.Distance(owner.target.transform.position, transform.position)) + (velocity - owner.target.m_velocity) * 2;
		
		//setando direção e força para tocar a bola
		Vector3 ball_direction = (owner.target.transform.position - transform.position).normalized;
		owner.ball.GetComponent<Ball>().mvec3_direction.x = ball_direction.x;
		owner.ball.GetComponent<Ball>().mvec3_direction.y = ball_direction.y;
		owner.ball.GetComponent<Ball>().mf_impulse = shootforce;
		//Debug.Log("Passing Ball");
	}

	public override bool Think()
	{
		/*Se existir um alvo selecionado
		 e a distancia até ele é maior que a
		 distancia minima de ação...*/
		if (owner.target != null)
			if (Vector3.Distance(owner.target.transform.position, transform.position) > owner.body.m_minactionray)
			return true;
		return false;
	}
}
