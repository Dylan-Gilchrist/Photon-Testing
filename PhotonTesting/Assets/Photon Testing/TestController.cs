using UnityEngine;
using Photon.Pun;
using System.Collections;

public class TestController : MonoBehaviour
{
    public float speed = 0.01f;
    public Camera playerCamera;
    
    //public PhotonView view;

    void Update()
    {   
        /*
        if (view.IsMine)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
   
            gameObject.transform.position = new Vector3 (transform.position.x + (h * speed), 0.5f, transform.position.z + (v * speed));
        }
        */

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
   
        gameObject.transform.position = new Vector3 (transform.position.x + (h * speed), 0.5f, transform.position.z + (v * speed));
    }
}