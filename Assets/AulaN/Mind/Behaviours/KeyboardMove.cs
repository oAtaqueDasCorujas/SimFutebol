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

public class KeyboardMove : AbstractBehaviour
{
	public override void Act ()
	{
		if (Input.GetKey (KeyCode.A)) 
		{
			owner.body.Shoot(Vector3.left);
			owner.body.Move(Vector3.left);
		}
		
		if (Input.GetKey (KeyCode.D)) 
		{
			owner.body.Move(Vector3.right);
		}
	}

	public override bool Think ()
	{
		if (Input.GetKey (KeyCode.A)) 
		{
			return true;
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			return true;
		}

		return false;
	}
}