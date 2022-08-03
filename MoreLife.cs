using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreLife : MonoBehaviour
{
    Lifebar life;
    public float vel = 1f;
    // Start is called before the first frame update
    void Start()
    {
        life = FindObjectOfType<Lifebar>();
    }

    public void Update()
    {
        transform.Translate(0, -vel * Time.deltaTime, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            life.lifecurrent = life.lifecurrent + 30;

        }

    }
}
