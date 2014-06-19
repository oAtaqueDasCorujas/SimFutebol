using UnityEngine;
using System.Collections;

public class Gol : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Bola")
        {
            Application.LoadLevel(Application.loadedLevel);

            if (gameObject.name == "gol1")
                Score.gol1++;
            else
                Score.gol2++;
        }
            
        
    }
}
