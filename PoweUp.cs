using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUp : MonoBehaviour
{
    public GameObject[] gun;
    public float vel = 1f;
    Mision msion;
    public int powerUp = 1;
    // Start is called before the first frame update
    void Start()
    {
        msion  = FindObjectOfType<Mision>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -vel * Time.deltaTime, 0);   
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            powerUp = powerUp +1;
            msion.txtPoweup.text = powerUp.ToString(); 
            gun[1].SetActive(true);
            

        }

    }
}
