using UnityEngine;
using System.Collections;

public class cameraPosition : MonoBehaviour {
        
    public GameObject camera;
    public Transform[] posCamera;
    public static int index;

	void Update () {

        Choice();

        if (index > 6)
        {
            camera.transform.position = posCamera[index].position;
        }
	
	}

    void Choice() {

        if (Input.inputString.Length > 0) {
		
			string keyPressedString = Input.inputString.Substring
									(Input.inputString.Length - 1, 1);
			Debug.Log(keyPressedString);

            index = int.Parse(keyPressedString);

            if (index >= 0 && index <= 9)
            {
                camera.transform.position = posCamera[index].position;
                camera.transform.rotation = posCamera[index].rotation;
            }			
		}
    }
}
