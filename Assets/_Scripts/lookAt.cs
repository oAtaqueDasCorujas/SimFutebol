using UnityEngine;
using System.Collections;

public class lookAt : MonoBehaviour {

    public Transform ball, player;

	void Start () {
        ball = GameObject.Find("Bola").transform;
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(ball);

        if (ball.position.x > player.position.x)
            player.localEulerAngles = new Vector3(0, 0, 270);
        else
            player.localEulerAngles = new Vector3(0, 0, 90);

        

	
	}
}
