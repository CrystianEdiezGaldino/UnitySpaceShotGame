using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUp : MonoBehaviour
{
    public GameObject[] gun;
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
        switch (msion.getPowe)
        {
            case 1:
                gun[1].SetActive(true);
                break;
            case 2:
                gun[2].SetActive(true);
                break;
            case 3:
                gun[3].SetActive(true);
                break;
      
            default:
                print("Full PoweUp");
                break;
        }
        print(msion.getPowe);
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
