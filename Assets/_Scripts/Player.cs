using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	//Ponteiro para bola 
	public GameObject mp_ball;
	//Ponteiro para o gol que faz gol
	public GameObject	mp_goal;
	//ponteiro para o jogador alvo
	public GameObject mp_target;
	//direção do jogador(passível de mudança de tipo) e da bola
	public Vector3 mvec3_direction, vec3_ball_direction;
	//velocidade, força do chute, precisão do chute
	public float mf_velocity, mf_shootforce, mf_shootprecision;

	void Awake()
	{
		mp_ball = GameObject.Find("Bola");
		mvec3_direction = vec3_ball_direction = Vector3.zero;
		mf_shootforce = mf_velocity = 0.0f;
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
