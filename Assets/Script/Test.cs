using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    float input;
    public float speed = 10f;
    public Rigidbody2D rb; 
    public CircleCollider2D cl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(input * speed * Time.fixedDeltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Maca")){
            Debug.Log("Pegou maca");
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Abacaxi")){
            Debug.Log("Pegou abacaxi");
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Melancia")){
            Debug.Log("Pegou melancia");
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Pessego")){
            Debug.Log("Pegou pessego");
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Morango")){
            Debug.Log("Pegou morango");
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Limao")){
            Debug.Log("Pegou Limao");
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Uva")){
            Debug.Log("Pegou mUva");
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Pera")){
            Debug.Log("Pegou Pera");
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("banana")){
            Debug.Log("Pegou Banana");
            Destroy(other.gameObject);
        }
    }
}

