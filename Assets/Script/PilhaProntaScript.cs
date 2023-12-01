using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilhaProntaScript : MonoBehaviour
{
    public Pilha p;

    public GameObject um;
    public GameObject dois;
    public GameObject tres;
    public GameObject quatro;
    public GameObject cinco;
    public GameObject seis;
    public GameObject sete;
    public GameObject oito;

    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<Pilha>();
        bool ok;
        p.Empilha(um, out ok);
        p.Empilha(dois, out ok);
        p.Empilha(tres, out ok);
        p.Empilha(quatro, out ok);
        p.Empilha(cinco, out ok);
        p.Empilha(seis, out ok);
        p.Empilha(sete, out ok);    
        p.Empilha(oito, out ok);
    }
}
