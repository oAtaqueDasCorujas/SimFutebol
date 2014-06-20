using UnityEngine;
using System.Collections;

public class changeLevel : MonoBehaviour {

    public string level;

	void Update () {

        if (Input.GetButton("Fire2") || Input.GetButton("Jump"))
        {
            Application.LoadLevel(level);
        }
      
	}
}
