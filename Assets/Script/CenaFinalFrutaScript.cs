using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cf_FrutaScript : MonoBehaviour
{
    public float cf_deadzone;
    public Rigidbody2D cf_Rigidbody;

    private Pilha cf_pilha;

    // Start is called before the first frame update
    void Start()
    {
        cf_pilha = GameObject.FindGameObjectWithTag("TADpilha").GetComponent<Pilha>();
        cf_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < cf_deadzone)
        {
            Destroy(gameObject);
        }
    }
}
