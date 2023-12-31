using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test:MonoBehaviour
{
    float input;
    public float speed = 10f;
    public Rigidbody2D rb;
    public CircleCollider2D cl;

    public GameObject MacaEs;
    public GameObject AbacaxiEs;
    public GameObject MelanciaEs;
    public GameObject PessegoEs;
    public GameObject MorangoES;
    public GameObject LimaoEs;
    public GameObject UvaEs;
    public GameObject PeraEs;
    public GameObject BananaEs;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(input * speed * Time.fixedDeltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D other){
        
        Pilha p = GameObject.FindGameObjectWithTag("TADpilha").GetComponent<Pilha>();
        bool ok;
        if (!p.Cheia())
        {
            if (other.gameObject.CompareTag("Maca"))
            {
                Debug.Log("Pegou maca");
                p.Empilha(MacaEs, out ok);
            }
            else if (other.gameObject.CompareTag("Abacaxi"))
            {
                Debug.Log("Pegou abacaxi");
                p.Empilha(AbacaxiEs, out ok);
            }
            else if (other.gameObject.CompareTag("Melancia"))
            {
                Debug.Log("Pegou melancia");
                p.Empilha(MelanciaEs, out ok);
            }
            else if (other.gameObject.CompareTag("Pessego"))
            {
                Debug.Log("Pegou pessego");
                p.Empilha(PessegoEs, out ok);
            }
            else if (other.gameObject.CompareTag("Morango"))
            {
                Debug.Log("Pegou morango");
                p.Empilha(MorangoES, out ok);
            }
            else if (other.gameObject.CompareTag("Limao"))
            {
                Debug.Log("Pegou Limao");
                p.Empilha(LimaoEs, out ok);
            }
            else if (other.gameObject.CompareTag("Uva"))
            {
                Debug.Log("Pegou Uva");
                p.Empilha(UvaEs, out ok);
            }
            else if (other.gameObject.CompareTag("Pera"))
            {
                Debug.Log("Pegou Pera");
                p.Empilha(PeraEs, out ok);
            }
            else if (other.gameObject.CompareTag("banana"))
            {
                Debug.Log("Pegou Banana");
                p.Empilha(BananaEs, out ok);
            }

            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("PilhaCheia");
        }
    }
}

