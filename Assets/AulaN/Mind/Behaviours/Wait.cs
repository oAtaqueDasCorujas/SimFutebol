//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

public class Wait : AbstractBehaviour
{
	public override void Act ()
	{
		owner.body.Move(Vector3.zero);
		Debug.Log("Waiting");
	}

	public override bool Think ()
	{
		return true;
	}
}

