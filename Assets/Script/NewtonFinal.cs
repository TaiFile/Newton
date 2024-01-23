using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtonFinal : MonoBehaviour
{
    public float input;
    public float speed = 10f;
    public Rigidbody2D rbb;
    public CircleCollider2D cll;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");
        rbb.velocity = new Vector2(input * speed * Time.fixedDeltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D test){
        
        if (test.gameObject.CompareTag("FMaca"))
        {
            Debug.Log("Pegou maca");
        }
        else if (test.gameObject.CompareTag("FAbacaxi"))
        {
            Debug.Log("Pegou abacaxi");
        }
        else if (test.gameObject.CompareTag("FMelancia"))
        {
            Debug.Log("Pegou melancia");
        }
        else if (test.gameObject.CompareTag("FPessego"))
        {
            Debug.Log("Pegou pessego");
        }
        else if (test.gameObject.CompareTag("FMorango"))
        {
            Debug.Log("Pegou morango");
        }
        else if (test.gameObject.CompareTag("FLimao"))
        {
            Debug.Log("Pegou Limao");
        }
        else if (test.gameObject.CompareTag("FUva"))
        {
            Debug.Log("Pegou Uva");
        }
        else if (test.gameObject.CompareTag("FPera"))
        {
            Debug.Log("Pegou Pera");
        }
        else if (test.gameObject.CompareTag("Fbanana"))
        {
            Debug.Log("Pegou Banana");
        }
        
    }
}