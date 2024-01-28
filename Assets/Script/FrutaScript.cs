using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrutaScript : MonoBehaviour
{
    public float deadzone = -1;
    public Rigidbody2D Rigidbody;
    public float TaxaDeAceleracao = 0.1f;
    public float GravCenaFinal;
    private Pilha pilha;
    public GameObject objEs;
    private GameObject fruta;

    // Start is called before the first frame update
    void Start()
    {
        pilha = GameObject.FindGameObjectWithTag("TADpilha").GetComponent<Pilha>();
        Rigidbody = GetComponent<Rigidbody2D>();

        Scene cenaAtiva = SceneManager.GetActiveScene();
        if (cenaAtiva.name == "CenaFinal")
        {
            Rigidbody.gravityScale = GravCenaFinal;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadzone)
        {
            Destroy(gameObject);
        }
        Rigidbody.gravityScale = 1f + pilha.GetCountNode() * TaxaDeAceleracao;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        bool ok;
        Scene cenaAtiva = SceneManager.GetActiveScene();

        if (other.gameObject.CompareTag("Player") && (cenaAtiva.name == "MainScene"))
        {
            Debug.Log("Pegou " + gameObject.tag);
            pilha.Empilha(objEs, out ok);
            Destroy(gameObject);
        }
    }
}
