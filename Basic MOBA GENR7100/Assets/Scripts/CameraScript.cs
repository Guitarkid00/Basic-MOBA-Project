using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Localcamera;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Localcamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 200, player.transform.position.z);
    }
}
