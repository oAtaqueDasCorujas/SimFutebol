//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.34014
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
		
public class SelectNearestTarget : AbstractBehaviour
{
	public float timer = 0;

	public override void Act ()
	{
		owner.target = null;
		float currentDistance = float.MaxValue;

		foreach (Body body in owner.enemies) 
		{
			float distance = Vector3.Distance(this.transform.position,
			                                  body.transform.position);

			if (distance < currentDistance)
			{
				currentDistance = distance;
				owner.target = body;
			}
		}
	}

	public override bool Think ()
	{
		if (timer > 1) 
		{
			timer = 0;
			return true;
		}

		timer += Time.deltaTime;

		return false;
	}
}