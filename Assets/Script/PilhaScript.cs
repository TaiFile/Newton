using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static UnityEngine.RuleTile.TilingRuleOutput;
public class Pilha : MonoBehaviour
{
    private class Node
    {
        public GameObject Info { get; set; }
        public Node Next { get; set; }
    }

    public int tamanhoMaximo;
    public float espacamento = 1.5f;

    private int countNode;
    private float alturaPilha;
    private Node topo;

    // Construtor e destrutor
    public Pilha()
    {
        topo = null;
    }

    ~Pilha()
    {
        Node aux;
        while (topo != null)
        {
            aux = topo;
            topo = topo.Next;
            aux = null;
            // No C#, o garbage collector cuida da liberação de memória, não é necessário chamar delete
        }
    }

    // Métodos primitivos
    public bool Vazia()
    {
        return topo == null;
    }

    public bool Cheia()
    {
        return countNode == tamanhoMaximo;
    }

    public void Empilha(GameObject ElementoNovo)
    {
        Node novoNode = new Node();
        if (novoNode == null) // cheia
        {
            
        }
        else
        {

            novoNode.Info = ElementoNovo;
            novoNode.Next = topo;

            Vector3 posicaoNovaFruta = transform.position + new Vector3(0, (countNode*espacamento) + ElementoNovo.transform.localScale.y, 0);
            Instantiate(ElementoNovo, posicaoNovaFruta, transform.rotation);
            countNode++;

            topo = novoNode;
            
        }
    }

    public void Desempilha(out GameObject x, bool DeuCerto)
    {
        if (Vazia())
        {
            x = null;// Valor padrão se a pilha estiver vazia
            DeuCerto = false;
        }
        else
        {
            Node eraseNode = topo;
            x = topo.Info;
            topo = topo.Next;
            Destroy(eraseNode.Info);
            countNode--;


            // No C#, o garbage collector cuida da liberação de memória, não é necessário chamar delete
            DeuCerto = true;
        }
    }
}


