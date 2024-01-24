using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test:MonoBehaviour
{
    float input;
    public float speed = 10f;
    public Rigidbody2D rb;
    public CircleCollider2D cl;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(input * speed * Time.fixedDeltaTime, 0);
    }
}

