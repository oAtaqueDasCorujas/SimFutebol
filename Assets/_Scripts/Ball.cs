using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
	public float m_impulse, m_desaceleracao, m_velocity;
	public Vector3 m_direction;

	void Awake()
	{
		m_impulse = 0.0f;
		m_desaceleracao = 0.1f;
		m_velocity = 0.0f;
		m_direction = Vector3.zero;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		m_velocity = m_impulse;
		transform.position = new Vector3(transform.position.x + (m_velocity * m_direction.x * Time.deltaTime),
													transform.position.y,
													transform.position.z + (m_velocity * m_direction.z * Time.deltaTime));
		m_impulse -= m_desaceleracao;
		if (m_impulse <= 0.001)
			m_impulse = 0.0f;
	}
}
