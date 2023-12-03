using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalFrutaScript : MonoBehaviour
{
    public float deadzonee;
    public Rigidbody2D Rigidbodyy;
    public float TaxaDeAceleracao = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbodyy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadzonee)
        {
            Destroy(gameObject);
        }
    }
}
