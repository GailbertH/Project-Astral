using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	public bool Range;
	public float Speed;
	public int Damage;
	[SerializeField] public Animation Anim;
	[SerializeField] public string Walk;
	[SerializeField] public string Run;
	[SerializeField] public string Idle;

	void Start()
	{
		Simula ();
	}
	public virtual void Simula()
	{
		Range = false;
		Speed = 1.5f;
		Damage = 2;
	}
	public virtual void Update()
	{
		Debug.Log(Speed + " : " + Range + " : " + Speed);
	}
}
