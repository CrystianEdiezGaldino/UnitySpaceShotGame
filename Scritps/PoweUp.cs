using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUp : MonoBehaviour
{
    
    public float vel = 1f;
    Mision msion;

    // Start is called before the first frame update
    void Start()
    {
        msion  = FindObjectOfType<Mision>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0, 0, -vel * Time.deltaTime);   
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            
            msion.getPowe = msion.getPowe + 1;


        }

    }
}
