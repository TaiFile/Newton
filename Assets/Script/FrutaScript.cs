using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrutaScript : MonoBehaviour
{
    public float deadzone;
    public Rigidbody2D Rigidbody;
    public float gravidade;
    

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody.gravityScale = gravidade;    
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
