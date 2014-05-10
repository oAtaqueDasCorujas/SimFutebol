using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour 
{
	public GameObject ball;
	public float m_velocity, m_shootforce, m_angle;
	public Vector3 m_direction;

	void Awake()
	{
		ball = GameObject.Find("Bola");
		m_velocity = 2.0f;
		m_shootforce = 5.0f;
		m_direction = Vector3.zero;
		m_angle = 0.0f;
	}
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		m_direction = ball.transform.position - transform.position;
		transform.position = new Vector3(transform.position.x + (m_velocity * m_direction.x * Time.deltaTime),
																			transform.position.y,
																			transform.position.z + (m_velocity * m_direction.z * Time.deltaTime));
		//Shoot();
	}

	void Shoot()
	{
		if(transform.position.x >=10.0f)
		{
			m_shootforce = 15.0f;
			m_angle = Random.RandomRange(-0.5f, 0.5f);
			m_velocity = 0.0f;
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.name == "Bola")
		{
			if (transform.position.x >= 10.0f)
			{
				m_shootforce = 15.0f;
				m_angle = Random.RandomRange(-0.5f, 0.5f);
				m_velocity = 0.0f;
			}
			col.GetComponent<Ball>().m_impulse = m_shootforce;
			col.GetComponent<Ball>().m_direction.x = Mathf.Cos(m_angle);
			col.GetComponent<Ball>().m_direction.z = Mathf.Sin(m_angle);
			Debug.Log(col.GetComponent<Ball>().m_direction);
			//Debug.Log("Colidiu");
		}
	}
}
