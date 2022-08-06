using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerControll : MonoBehaviour
{

    public float speed = 10f;
    
    public float xMinimo;
    public float xMaximo;
    public float zMinimo;
    public float zMaximo;
    public GameObject[] gun;

    Lifebar life;
    Mision msion;
    private void Start()
    {
        life = FindObjectOfType<Lifebar>();
        msion = FindObjectOfType<Mision>();
    }

    public void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMinimo, xMaximo)
          ,transform.position.y, Mathf.Clamp(transform.position.z, zMinimo, zMaximo));
        float inputX = Input.GetAxisRaw("Horizontal");
		float InputZ = Input.GetAxisRaw("Vertical");

       Vector3 moveToPlayer = new Vector3(speed * inputX, 0, speed * InputZ);
       moveToPlayer *= Time.deltaTime;
       transform.Translate(moveToPlayer);

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
        

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enimy"))
        {
            life.lifecurrent = life.lifecurrent - 10;
            
        }
        
    }



}

