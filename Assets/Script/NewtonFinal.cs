using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewtonFinal : MonoBehaviour
{
    float input;
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
}