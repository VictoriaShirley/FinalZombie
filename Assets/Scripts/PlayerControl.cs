using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float Velocidade = 8;
    Vector3 direcao;
    public LayerMask MascaraChao;
    public GameObject TextoGameOver;

    public bool Vivo = true;
    public int Vida = 100;
    public ControlaInterface scriptControlaInterface;
    public AudioClip SomDeDano; // Audio de dano



    void Start()
    {
        Time.timeScale = 1;
        TextoGameOver.SetActive(false);
    }

    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        direcao = new Vector3(eixoX, 0, eixoZ);

        if(direcao != Vector3.zero){
            GetComponent<Animator>().SetBool("Correndo", true);
        }

        else
        {
            GetComponent<Animator>().SetBool("Correndo", false);
        }    
        if (Vida <= 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }

    void FixedUpdate()

    {

        float eixoX = Input.GetAxis("Horizontal");

        float eixoZ = Input.GetAxis("Vertical");


        direcao = new Vector3(eixoX, 0, eixoZ);
        direcao.Normalize(); // Normaliza a direção para evitar movimento mais rápido na diagonal

        // Define a velocidade atual do jogador com a direção e velocidade configuradas
        Vector3 velocidade = direcao * Velocidade;
        GetComponent<Rigidbody>().velocity = velocidade;

        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit impacto;

        if (Physics.Raycast(raio, out impacto, 100, MascaraChao))
        {
            Vector3 posicaoMiraJogador = impacto.point - transform.position;
            Quaternion novaRotacao = Quaternion.LookRotation(posicaoMiraJogador);
            GetComponent<Rigidbody>().MoveRotation(novaRotacao);
        }

    }


    public void TomarDano (int dano)
    {
        Vida -= dano;
        scriptControlaInterface.AtualizaSliderVidaJogador();
        ControlaAudio.instance.PlayOneShot(SomDeDano); // Toca o som de dano


        if (Vida <= 0)
            {
                Time.timeScale = 0;
                TextoGameOver.SetActive(true);
            }
    }
}
 