using UnityEngine;
using Photon.Pun;
using System.Collections;

public class TestController : MonoBehaviour
{
    public float speed = 0.1f;
    public Camera playerCamera;

    void Update()
    {   
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
   
        gameObject.transform.position = new Vector3 (transform.position.x + (h * speed), 0.51f, transform.position.z + (v * speed));
    }
}