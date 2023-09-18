using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ContadorDeMonstros : MonoBehaviour
{
    public int MonstrosDerrotados = 0;
    public Text ContadorText;

    // Start is called before the first frame update

    void Start()
    {
        AtualizarTextoContador();
    }

    public void IncrementarContadorMonstros()
    {
        MonstrosDerrotados++;
        AtualizarTextoContador();
    }

 
    void AtualizarTextoContador()
    {
        ContadorText.text = "Zumbis derrotados: " + MonstrosDerrotados;
    }
}
