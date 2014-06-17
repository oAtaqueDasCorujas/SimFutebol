using System;
using UnityEngine;

public class SelectTarget : AbstractBehaviour
{
	public Body debugtarget;

	public override void Act()
	{
		//Se nenhum alvo ainda foi selecionado
		if (owner.target == null)
		{
			SelectForNullTarget();
		}
		//Se já há um alvo previamente selecionado
		if (owner.target != null)
		{
			SelectBestTarget();
		}
	}

	public override bool Think()
	{
		//Se o jogador estiver a uma distancia minima da bola
		//ele pode procurar um alvo
		if (Vector3.Distance(owner.ball.transform.position, transform.position) 
				< owner.body.m_ballaction)
			return true;
		return false;
	}

	public void SelectForNullTarget()
	{
		foreach (Body p_target in owner.allies)
		{
			/*Se a distancia até o objeto for maior que
			 a distancia minima de ação...*/
			if ((Vector3.Distance(p_target.transform.position,
						transform.position)) > owner.body.m_minactionray)
			{
				/*Se a distancia até o objeto for menor
				 que a distancia maxima de ação...*/
				if ((Vector3.Distance(p_target.transform.position,
						transform.position)) < owner.body.m_actionray)
				{
					//Alvo é selecionado
					owner.target = p_target;
					debugtarget = p_target;
					//Debug.Log("Procurando alvo novo");
					break;
				}
			}
		}
	}

	public void SelectBestTarget()
	{
		//distancia até o antigo alvo
		float distance = Vector3.Distance(owner.target.transform.position, transform.position);
		foreach (Body p_target in owner.allies)
		{
			//Debug.Log("Reinicio de busca");

			/*Se a distancia do objeto for menor que
			 a distancia ao alvo antigo...*/
			if (Vector3.Distance(p_target.transform.position,
								transform.position) < distance)
			{
				//Debug.Log("menor distancia");

				/*Se a distancia do objeto for menor que
				 a distancia minima de ação...*/
				if (Vector3.Distance(p_target.transform.position, transform.position)
					> owner.body.m_minactionray)
				{
					owner.target = p_target;
					debugtarget = p_target;
					//Debug.Log("Procurando Melhor alvo");
					break;
				}
				else
				{
					owner.target = null;
					debugtarget = null;
					//Debug.Log("Perdendo alvo");
					break;
				}
			}
		}
	}
}
