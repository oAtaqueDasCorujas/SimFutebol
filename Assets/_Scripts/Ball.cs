using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
	//impulso, fator de desaceleração, velocidade
	public float mf_impulse, mf_velocity;
	public float mf_desaceleracao = 0.1f;
	//direção, setada pelo player
	public Vector3 mvec3_direction;

	void Awake()
	{
		mf_impulse = 0.0f;
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
																		transform.position.y + (mf_velocity * mvec3_direction.y * Time.deltaTime),
																		0.0f);
		
        mf_impulse -= mf_desaceleracao;
		
        if (mf_impulse <= 1.0f)
			mf_impulse = 1.0f;
	}
}
