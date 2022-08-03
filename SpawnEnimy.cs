using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnimy : MonoBehaviour
{
    public GameObject[] SpawnItens;
    int random;
    public float spawntime;
    public float spawndelay;
    public bool move = true;
    public bool movestart = true;
    public float movespeed =3f;


    void Start()
    {
        InvokeRepeating("SpawnRandom", spawntime, spawndelay);
    }

    void SpawnRandom()
    {
        random = Random.Range(0, SpawnItens.Length);
        Instantiate(SpawnItens[random], transform.position, transform.rotation);

    }
    public void Update()
    {
       

        if (transform.position.x > 1.76f)
            {
                move = false;
            }
            else if (transform.position.x < -2f)
            {
                move = true;
            }
            if (move)
            {
                transform.Translate(Vector3.right * movespeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.right * -movespeed * Time.deltaTime);
            }
       
        
    }

}
