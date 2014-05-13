using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public GameObject ball;
	public float m_velocity, m_shootforce, m_angle;
	public Vector3 m_direction, ball_direction;

	void Awake()
	{
		ball = GameObject.Find("Bola");
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
