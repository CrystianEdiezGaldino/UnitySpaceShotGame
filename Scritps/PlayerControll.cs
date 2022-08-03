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

    Lifebar life;
    private void Start()
    {
        life = FindObjectOfType<Lifebar>();
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

        

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enimy"))
        {
            life.lifecurrent = life.lifecurrent - 10;
            
        }
        
    }



}

