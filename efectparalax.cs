using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class efectparalax : MonoBehaviour
{
    [SerializeField] private Renderer fundo;
    [SerializeField] private float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveFundo();
    }
    public void MoveFundo()
    {
        Vector2 offset = new Vector2(0, -velocidade * Time.deltaTime);

        fundo.material.mainTextureOffset += offset;
    }
}
