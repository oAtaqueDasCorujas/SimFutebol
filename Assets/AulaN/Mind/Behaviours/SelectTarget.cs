using System;
using UnityEngine;

public class SelectTarget : AbstractBehaviour
{
	public Body debugtarget;
	public Body t_bodytarget;

	public override void Act()
	{
		//Se nenhum alvo ainda foi selecionado
		if (owner.target == null)
		{
			owner.target = SelectForNullTarget();
		}
		//Se já há um alvo previamente selecionado
		if (owner.target != null)
		{
			owner.target = SelectBestTarget();
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

	public Body SelectForNullTarget()
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
					//Debug.Log("Procurando alvo novo");
					t_bodytarget = p_target;
				}
			}
		}
		/*Caso nenhum alvo seja selecionado
		 executa-se a função novamente*/
		if (t_bodytarget == null)
			SelectForNullTarget();
		return t_bodytarget;
	}

	public Body SelectBestTarget()
	{
		//distancia até o antigo alvo
		float distance = Vector3.Distance(owner.target.transform.position, transform.position);
		//distancia do alvo antigo até o gol
		float g_distance = Vector3.Distance(owner.goaltoscore.transform.position, owner.target.transform.position);
		
		foreach (Body p_target in owner.allies)
		{
			/*Se a distancia até o objeto for menor que
			 a distancia até o alvo antigo for menor...*/
			if (Vector3.Distance(p_target.transform.position, 
						transform.position)	< distance)
			{
				/*Se a distancia do objeto até o gol for
				 menor que a distancia do alvo antigo
				 até o gol...*/
				if (Vector3.Distance(owner.goaltoscore.transform.position,
							p_target.transform.position) < g_distance)
				{
					/*Se a distancia até o objeto for maior
					 * que a distancia minima de ação...*/
					if ((Vector3.Distance(p_target.transform.position,
						transform.position)) > owner.body.m_minactionray)
					{
						/*Se a distancia até o objeto for
						 * menor que a distancia de ação 
						 * de ação...*/
						if ((Vector3.Distance(p_target.transform.position,
								transform.position)) < owner.body.m_actionray)
						{
							//Seleciona-se um possivel alvo
							t_bodytarget = p_target;
						}
					}
				}
			}
		}
		/*Se o alvo selecionado for o alvo antigo
		 * e a distancia até ele for menor que
		 * a distancia minima de ação...*/
		if (t_bodytarget == owner.target)
			if ((Vector3.Distance(t_bodytarget.transform.position,
								transform.position)) < owner.body.m_minactionray)
				return null;
		return t_bodytarget;
	}
}
