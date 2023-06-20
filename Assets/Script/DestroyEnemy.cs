using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public float movementSpeed = 5f;
    public GameObject particula;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = Random.Range(1, 5);
        Rigidbody2D objectRigidbody = GetComponent<Rigidbody2D>();
        objectRigidbody.velocity = Vector2.down * movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(particula, transform.position, Quaternion.identity);
            
            if (gameObject.tag == "BUENO")
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<Points>().SumarPuntos(100);
                FindObjectOfType<SoundManager>().Play("bueno");

            }
            else if(gameObject.tag == "MALO")
            {
                FindObjectOfType<SoundManager>().Play("hit");
                GameObject.FindGameObjectWithTag("Player").GetComponent<LifePlayer>().TakeDamage(20);
                GameObject.FindGameObjectWithTag("Player").GetComponent<Points>().RestarPuntos(50);
                
            }
            Destroy(gameObject);
        }
    }
}
