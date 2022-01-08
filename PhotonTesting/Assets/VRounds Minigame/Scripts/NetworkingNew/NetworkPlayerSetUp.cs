using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPlayerSetUp : MonoBehaviour
{
    public GameObject localCamera;
    
    [Space]
    public TestController localPlayerController;

    public void IsLocalPlayer()
    {
        localCamera.SetActive(true);
        localPlayerController.enabled = true;
    }
}
