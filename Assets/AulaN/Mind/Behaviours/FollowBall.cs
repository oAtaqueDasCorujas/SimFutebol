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
			transform.position) > owner.body.m_actionray)
			return false;
		return true;
	}
}
