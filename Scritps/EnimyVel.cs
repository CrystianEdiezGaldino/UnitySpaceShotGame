using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimyVel : MonoBehaviour
{
    public float vel = 1f;
    [SerializeField]
    private float tumble = 1f;
    public GameObject explosion;
    public int lifeEnimy = 20;
    GameObject player;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -vel * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        if (lifeEnimy <=0)
        {
            Destroy(gameObject);
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {

            lifeEnimy = lifeEnimy - 10;
            Instantiate(explosion, new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z), Quaternion.identity);

        }
        else
        {
            Destroy(gameObject, 5f);
        }
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(explosion, new Vector3(transform.localPosition.x, transform.localPosition.y,transform.localPosition.z), Quaternion.identity);

        }
        else
        {
            Destroy(gameObject, 5f);
        }
    }
}
