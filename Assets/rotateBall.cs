using UnityEngine;
using System.Collections;

public class rotateBall : MonoBehaviour {

    public float scrollSpeed, offset;

    void Update()
    {
        scrollSpeed = GetComponent<Ball>().mf_velocity / 2;
        offset = Time.time * scrollSpeed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, offset));
    }
}
