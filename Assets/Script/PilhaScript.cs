using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
class Pilha
{
    private class Node
    {
        public int Info { get; set; }
        public Node Next { get; set; }
    }

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
            // No C#, o garbage collector cuida da liberação de memória, não é necessário chamar delete
        }
    }

    // Métodos primitivos
    public bool Vazia()
    {
        return topo == null;
    }

    public void Empilha(int ElementoNovo, out bool DeuCerto)
    {
        Node novoNode = new Node();
        if (novoNode == null) // cheia
        {
            DeuCerto = false;
        }
        else
        {
            novoNode.Info = ElementoNovo;
            novoNode.Next = topo;
            topo = novoNode;
            DeuCerto = true;
        }
    }

    public void Desempilha(out int x, out bool DeuCerto)
    {
        if (Vazia())
        {
            x = 0; // Valor padrão se a pilha estiver vazia
            DeuCerto = false;
        }
        else
        {
            Node eraseNode = topo;
            x = topo.Info;
            topo = topo.Next;
            // No C#, o garbage collector cuida da liberação de memória, não é necessário chamar delete
            DeuCerto = true;
        }
    }
}


