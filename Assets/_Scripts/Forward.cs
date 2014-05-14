using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour 
{
	public GameObject ball, gol, alvo;
	public float m_velocity, m_shootforce, m_angle;
	public Vector3 m_direction, ball_direction;

	void Awake()
	{
		ball = GameObject.Find("Bola");
		gol = GameObject.Find("TraveDir");
		alvo = GameObject.Find("Jogador");
		m_velocity = 2.0f;
		m_shootforce = 5.0f;
		m_direction = ball_direction = Vector3.zero;
		m_angle = 0.0f;
	}
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		m_direction = (ball.transform.position - transform.position).normalized;
		transform.position = new Vector3(transform.position.x + (m_velocity * m_direction.x * Time.deltaTime),
																			transform.position.y,
																			transform.position.z + (m_velocity * m_direction.z * Time.deltaTime));
		Debug.Log(m_shootforce);
	}

	void PassBall(Collider col)
	{
		//if (Vector3.Distance(alvo.transform.position, transform.position) <= 5.0f)
		{
			//m_shootforce = Mathf.Sqrt(2 * 5f * Vector3.Distance(alvo.transform.position, transform.position)) + alvo.GetComponent<Test>().m_velocity*2;
			//m_shootforce = (Mathf.Pow(alvo.GetComponent<Test>().m_velocity, 2) * Vector3.Distance(alvo.transform.position, transform.position)) / 2;
			m_shootforce = Mathf.Sqrt(2 * 5 * Vector3.Distance(alvo.transform.position, transform.position)) + (m_velocity - alvo.GetComponent<Test>().m_velocity) * 2;
			ball_direction = (alvo.transform.position - ball.transform.position).normalized;
			col.GetComponent<Ball>().mvec3_direction.x = ball_direction.x;
			col.GetComponent<Ball>().mvec3_direction.z = ball_direction.z;
		}
	}

	void Shoot(Collider col)
	{
		m_shootforce = 15.0f;
		int r = Random.Range(0, 5);

		if (r <=2)
			m_angle = Random.Range(-0.2f, 0.2f);
		else
			m_angle = Random.Range(-0.8f, 0.8f);
		
		col.GetComponent<Ball>().mvec3_direction.x = Mathf.Cos(m_angle);
		col.GetComponent<Ball>().mvec3_direction.z = Mathf.Sin(m_angle);
		m_velocity = 0.0f;
	}

	void MoveForward (Collider col)
	{
		m_shootforce = 5f;
		ball_direction = (gol.transform.position - ball.transform.position).normalized;
		col.GetComponent<Ball>().mvec3_direction.x = ball_direction.x;
		col.GetComponent<Ball>().mvec3_direction.z = ball_direction.z;
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.name == ball.name)
		{
			/*if (transform.position.x >= 10.0f)
			{
				Shoot(col);
			}*/
			if (Vector3.Distance(alvo.transform.position, transform.position) <= 15.0f)
			{
				PassBall(col);
				//Debug.Log(Vector3.Distance(alvo.transform.position, transform.position));
			}
			else
			{
				MoveForward(col);
			}
			col.GetComponent<Ball>().mf_impulse = m_shootforce;
			//Debug.Log("colidiu");
		}
	}
}
