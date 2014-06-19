using System;
using UnityEngine;

public class FollowBall : AbstractBehaviour 
{
	public override void Act()
	{
		//Passa-se a direção da bola para a função de movimento
		Vector3 direction = (owner.ball.transform.position - transform.position).normalized;
		owner.body.Move(direction);
		//Debug.Log("Moving to Ball");
		//Debug.Log(transform.position);
	}

	public override bool Think()
	{
		/*Se a bola distancia até a bola for menor
		 que a distancia minima de ação da bola
		 ou
		 se a distancia até a bola for maior que o
		 raio de ação do personagem...*/
        
		if (Vector3.Distance(owner.ball.transform.position, 
			transform.position) < owner.body.m_ballaction ||
				Vector3.Distance(owner.ball.transform.position,
            transform.position) > owner.body.m_actionray ||
						BallAlreadyOur())
			return false;
		return true;
	}

	//Verifica se alguem do meu time ja esta proximo a bola
	public bool BallAlreadyOur()
	{
		for (int i = 0; i < owner.allies.Count; i++)
		{
			if (Vector3.Distance(owner.allies[i].transform.position,
					owner.ball.transform.position) < owner.body.m_ballaction*2)
			{
				return true;
			}
		}
		return false;
	}
}
