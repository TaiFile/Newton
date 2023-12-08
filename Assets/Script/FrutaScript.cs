using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrutaScript : MonoBehaviour
{
    public float deadzone;
    public Rigidbody2D Rigidbody;
    public float TaxaDeAceleracao = 0.25f;
    public float GravCenaFinalMaca;
    private Pilha pilha;

    // Start is called before the first frame update
    void Start()
    {
        pilha = GameObject.FindGameObjectWithTag("TADpilha").GetComponent<Pilha>();
        Rigidbody = GetComponent<Rigidbody2D>();

        Scene cenaAtiva = SceneManager.GetActiveScene();
        if (cenaAtiva.name == "CenaFinalMaca")
        {
            Rigidbody.gravityScale = GravCenaFinalMaca;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadzone)
        {
            Destroy(gameObject);
        }

        if (pilha.GetCountNode() != 0)
        {
            Rigidbody.gravityScale = 1f + pilha.GetCountNode() * TaxaDeAceleracao;
        }
        else
        {
            Rigidbody.gravityScale = 1f;
        }
    }
}
