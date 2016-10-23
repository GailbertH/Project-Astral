using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : NewBehaviourScript 
{
	public override void Simula ()
	{
		base.Simula ();
		Range = true;
	}
	public override void Update()
	{
		Debug.Log(Walk + " : " + Run + " : " + Idle + gameObject.name);
	}
}
