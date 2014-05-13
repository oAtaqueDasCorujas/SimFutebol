using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour 
{
	public float m_velocity = 1f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(transform.position.x + (m_velocity * Time.deltaTime),
																			transform.position.y,
																			transform.position.z);
	}
}
