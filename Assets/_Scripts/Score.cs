using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public static int gol1,gol2;
	
	// Update is called once per frame
	void Update () {
        if (name == "vermelho")
            guiText.text = gol1.ToString();
        else
            guiText.text = gol2.ToString();
	}
}
