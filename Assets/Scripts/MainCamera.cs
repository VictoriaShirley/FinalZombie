using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    Vector3 distanciaMainCameraPlayer;
    void Start()
    {
        distanciaMainCameraPlayer = transform.position - player.transform.position;   
    }
 
    void Update()
    {
        transform.position = player.transform.position + distanciaMainCameraPlayer;
    }
}
