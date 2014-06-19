using UnityEngine;
using System.Collections;

public class PassBall : AbstractBehaviour 
{
	public float passforce = 0;
	public override void Act()
	{
		/*força ou velocidade do toque da bola retirada da formula
		 (m*v^2)/2 = f*d 
		 A seguir eu escolhi isolar velocidade, mas é possivel
		 também fazer isolando força, tudo depende da forma
		 como iremos implementar a aceleração, impulso e 
		 velocidade da bola*/

		//passforce = Mathf.Sqrt(2 * 5f * Vector3.Distance(owner.target.transform.position, transform.position)) + owner.target.m_velocity * 2;
		//passforce = (Mathf.Pow(owner.target.m_velocity, 2) * Vector3.Distance(owner.target.transform.position, transform.position)) / 2;
		passforce = Mathf.Sqrt(2 * 5 * Vector3.Distance(owner.target.transform.position, transform.position)) + (owner.target.m_velocity) * 2;
		
		//setando direção e força para tocar a bola
		Vector3 ball_direction = (owner.target.transform.position - transform.position).normalized;
		owner.ball.GetComponent<Ball>().mvec3_direction.x = ball_direction.x;
		owner.ball.GetComponent<Ball>().mvec3_direction.y = ball_direction.y;
		owner.ball.GetComponent<Ball>().mf_impulse = passforce;
		passforce = 0.0f;
		//Debug.Log("Passing Ball");
	}

	public override bool Think()
	{
		/*Se existir um alvo selecionado
		 e a distancia até ele é maior que a
		 distancia minima de ação...*/
		if (owner.target != null)
			if (Vector3.Distance(owner.target.transform.position, transform.position) > owner.body.m_minactionray)
				if(Vector3.Distance(owner.ball.transform.position, transform.position) < owner.body.m_ballaction)
			return true;
		return false;
	}
}
