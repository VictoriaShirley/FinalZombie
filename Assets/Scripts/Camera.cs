using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject player;
    Vector3 distanciaMoveCameraPlayer;
    void Start()
    {
        distanciaMoveCameraPlayer = transform.position - player.transform.position;   
    }
 
    void Update()
    {
        transform.position = player.transform.position + distanciaMoveCameraPlayer;
    }
}
