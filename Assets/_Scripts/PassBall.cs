using UnityEngine;
using System.Collections;

public class PassBall : MonoBehaviour 
{
	void Pass(GameObject ball, GameObject target)
	{
		/*força ou velocidade do toque da bola retirada da formula
		 (m*v^2)/2 = f*d 
		 A seguir eu escolhi isolar velocidade, mas é possivel
		 também fazer isolando força, tudo depende da forma
		 como iremos implementar a aceleração, impulso e 
		 velocidade da bola*/

		float m_shootforce, m_velocity = 0;
		//m_shootforce = Mathf.Sqrt(2 * 5f * Vector3.Distance(alvo.transform.position, transform.position)) + alvo.GetComponent<Test>().m_velocity*2;
		//m_shootforce = (Mathf.Pow(alvo.GetComponent<Test>().m_velocity, 2) * Vector3.Distance(alvo.transform.position, transform.position)) / 2;
		m_shootforce = Mathf.Sqrt(2 * 5 * Vector3.Distance(target.transform.position, transform.position)) + (m_velocity - target.GetComponent<Test>().m_velocity) * 2;

		Vector3 ball_direction = (target.transform.position - transform.position).normalized;
		ball.GetComponent<Ball>().m_direction.x = ball_direction.x;
		ball.GetComponent<Ball>().m_direction.z = ball_direction.z;
	}
}
