using UnityEngine;
using System.Collections;

public class fieldLimit : MonoBehaviour {

    Vector3 direction;

    void OnTriggerEnter(Collider other)
    {
        direction = other.GetComponent<Ball>().mvec3_direction;

        if (gameObject.name == "parede") {
            direction = new Vector3(direction.x * -1, direction.y, direction.z);
            other.GetComponent<Ball>().mf_impulse = 10;
            if (other.transform.position.x > 0)
                other.transform.position = new Vector3 (16, ((other.transform.position.y < 0)? 2 : -2), 0);
            else
                other.transform.position = new Vector3 (-16, ((other.transform.position.y < 0)? 2 : -2), 0);
        }            
        else if (gameObject.name == "paredeLateral")
            direction = new Vector3(direction.x, direction.y * -1, direction.z);
        else
            direction *= -1;

        other.GetComponent<Ball>().mvec3_direction = direction;
    }
}
