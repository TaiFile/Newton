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

    // Construtor
    public Pilha()
    {
        topo = null;
    }

    // Métodos primitivos

    public int GetCountNode()
    {
        return countNode;
    }

    public bool Vazia()
    {
        return topo == null;
    }

    public bool Cheia()
    {
        return countNode == tamanhoMaximo;
    }

    public void Empilha(GameObject ElementoNovo, out bool ok)
    {
        Node novoNode = new Node();
        if (Cheia())
        {
            ok = false;

            // Print de verificação em console
            Debug.Log("Pilha Cheia!!!");
        }
        else
        {
            Vector3 posicaoNovaFruta = transform.position + new Vector3(0, countNode*alturaNode, 0);
            Instantiate(ElementoNovo, posicaoNovaFruta, transform.rotation);
            
            novoNode.Info = ElementoNovo;
            novoNode.Next = topo;
            topo = novoNode;
            
            countNode++;
            ok = true;

            // Print de verificação em console
            Debug.Log("Empilhou Elemento!!!");
        }
    }

    public void Desempilha(out GameObject x, out bool DeuCerto)
    {
        Node eraseNode;
        if (Vazia())
        {
            x = null;                 // Valor padrão se a pilha estiver vazia
            DeuCerto = false;

            // Print de verificação em console
            Debug.Log("Pilha Vazia!!!");
        }
        else
        {
            x = topo.Info;
            eraseNode = topo;
            topo = eraseNode.Next;
            // Em C#, o garbage collector cuida da liberação de memória, não é necessário usar delete em eraseNode

            GameObject frutaDestruida = GameObject.Find(eraseNode.Info.name + "(Clone)");
            Destroy(frutaDestruida);
        
            countNode--;
            DeuCerto = true;

            // Print de verificação em console
            Debug.Log("Desempilhou!!!");
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
        
        GameObject x; bool ok;
        while (!Vazia())
        {
            Desempilha(out x, out ok);
            
        }
    }
}


