using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public GameObject Bala;
    public GameObject CanoDaArma;
    // Start is called before the first frame update
    public AudioClip SomDeTiro; // Audio de dano

    
    void Update()
    {

        if (Input.GetButtonDown ("Fire1"))
        {
            Instantiate(Bala, CanoDaArma.transform.position, CanoDaArma.transform.rotation);
            ControlaAudio.instance.PlayOneShot(SomDeTiro); // Toca o som de dano

        }
    }
}

