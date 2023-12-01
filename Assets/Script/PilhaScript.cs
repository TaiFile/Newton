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
    public float alturaNode = 2;
    private int countNode;
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

    public int GetCountNode()
    {
        return countNode;
    }

    public bool Vazia()
    {
        return topo == null || countNode == 0;
    }

    public bool Cheia()
    {
        return countNode == tamanhoMaximo;
    }

    public void Empilha(GameObject ElementoNovo, out bool ok)
    {
        Node novoNode = new Node();
        if (Cheia()) // cheia
        {
            ok = false;
        }
        else
        {
            novoNode.Info = ElementoNovo;
            novoNode.Next = topo;

            Vector3 posicaoNovaFruta = transform.position + new Vector3(0, countNode*alturaNode, 0);
            Instantiate(ElementoNovo, posicaoNovaFruta, transform.rotation);
            countNode++;
            topo = novoNode;
            ok = true;
        }
    }

    public void Desempilha(out GameObject x, out bool DeuCerto)
    {
        if (Vazia())
        {
            x = null;                 // Valor padrão se a pilha estiver vazia
            DeuCerto = false;
            Debug.Log("tentou desempilhar vazia");
        }
        else
        {
            Node eraseNode = topo;
            x = topo.Info;
            topo = topo.Next;
            eraseNode.Info.GetComponent<SpriteRenderer>().enabled = false;
            //Destroy(eraseNode.Info);
            eraseNode = null;
            countNode--;              // No C#, o garbage collector cuida da liberação de memória, não é necessário chamar delete
            DeuCerto = true;
        }
    }

    public bool compara_pilha(Pilha comparada)
    {
        if (countNode != comparada.countNode)
        {
            return false;
        }
        Node nodep1 = topo;
        Node nodep2 = comparada.topo;
        while (nodep1 != null)
        {
            if (nodep2.Info != nodep1.Info)
            {
                return false;
            }
            nodep1 = nodep1.Next;
            nodep2 = nodep2.Next;
        }
        return true;
    }

    public void DestroiPilha()
    {
        //Node aux;
        GameObject x; bool ok;
        while (!Vazia())
        {
            Desempilha(out x, out ok);
            //aux = topo;
            //topo = topo.Next;
            //Destroy(aux.Info);
            //countNode--;
        }
    }
}


