using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int pontos = 20;
    public int pontosatual;
    public Text txtPontos;

    // Start is called before the first frame update
    void Start()
    {
        txtPontos.text = "0";
        pontosatual = pontos;
    }

    // Update is called once per frame
    void Update()
    {
        txtPontos.text = pontosatual.ToString();
        

    }
   
}
