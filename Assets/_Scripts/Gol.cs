using UnityEngine;
using System.Collections;

public class Gol : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Bola")
            Application.LoadLevel(Application.loadedLevel);
        
    }
}
