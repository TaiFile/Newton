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
        rb.velocity = new Vector2(input * speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Maca")){
            Debug.Log("Pegou maca");
            Destroy(other.gameObject);
        }
    }
}

