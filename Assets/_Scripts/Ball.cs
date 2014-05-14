using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
	//impulso, fator de desaceleração, velocidade
	public float mf_impulse, mf_desaceleracao, mf_velocity;
	//direção, setada pelo player
	public Vector3 mvec3_direction;

	void Awake()
	{
		mf_impulse = 0.0f;
		mf_desaceleracao = 0.1f;
		mf_velocity = 0.0f;
		mvec3_direction = Vector3.zero;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		mf_velocity = mf_impulse;
		transform.position = new Vector3(transform.position.x + (mf_velocity * mvec3_direction.x * Time.deltaTime),
													transform.position.y,
													transform.position.z + (mf_velocity * mvec3_direction.z * Time.deltaTime));
		mf_impulse -= mf_desaceleracao;
		if (mf_impulse <= 0.001)
			mf_impulse = 0.0f;
	}
}
