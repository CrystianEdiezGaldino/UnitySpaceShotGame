using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projetil : MonoBehaviour
{
    public float speed;
    Points pontos;
    Mision mision;

    private void Start()
    {
        pontos = FindObjectOfType<Points>();
        mision = FindObjectOfType<Mision>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speed * Time.deltaTime);

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enimy"))
        {
            pontos.pontosatual = pontos.pontosatual + 50;
            mision.qtEnimy = mision.qtEnimy + 1;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 2f);
        }
    }
}
