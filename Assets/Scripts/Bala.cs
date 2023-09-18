using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float Velocidade = 20;
    public GameObject Contador;

    void Start() 
    {
        Contador = GameObject.FindWithTag("Player");
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition
            (GetComponent<Rigidbody>().position +
            transform.forward * Velocidade * Time.deltaTime);
    }

    void OnTriggerEnter(Collider objetoDeColisao)
    {
        ContadorDeMonstros contadorScript = Contador.GetComponent<ContadorDeMonstros>();

        if(objetoDeColisao.tag == "Inimigo")
        {
            Destroy(objetoDeColisao.gameObject);
            contadorScript.IncrementarContadorMonstros();
        }      
        Destroy(gameObject);
    }
}



 


 


