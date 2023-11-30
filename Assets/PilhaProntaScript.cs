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

        p.Empilha(um);
        p.Empilha(dois);
        p.Empilha(tres);
        p.Empilha(quatro);
        p.Empilha(cinco);
        p.Empilha(seis);
        p.Empilha(sete);
        p.Empilha(oito);
    }
}
