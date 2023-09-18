using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaInterface : MonoBehaviour
{
    private PlayerControl scriptPlayerControl;
    public Slider SliderVidaJogador;
    // Start is called before the first frame update
    void Start()
    {
        scriptPlayerControl = GameObject.FindWithTag("Player").GetComponent<PlayerControl>();
        SliderVidaJogador.maxValue = scriptPlayerControl.Vida;
        AtualizaSliderVidaJogador();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtualizaSliderVidaJogador ()
    {
        SliderVidaJogador.value = scriptPlayerControl.Vida;
    }
}