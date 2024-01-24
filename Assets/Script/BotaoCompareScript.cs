using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoCompareScript : MonoBehaviour
{

    private Pilha pilhaAtual;
    private Pilha pilhaPronta;
    private MacaSpawnerCode spawner;


    private void OnTriggerEnter2D(Collider2D other)
    {
        pilhaAtual = GameObject.FindGameObjectWithTag("TADpilha").GetComponent<Pilha>();
        pilhaPronta = GameObject.FindGameObjectWithTag("pilhaPronta").GetComponent<Pilha>();
        spawner = GameObject.FindGameObjectWithTag("spawner").GetComponent <MacaSpawnerCode>();

        if (other.gameObject.CompareTag("Player"))
        {
            bool saoIguais = pilhaAtual.compara_pilha(pilhaPronta);
            if (saoIguais)
            {
                spawner.pilhasIguais = true;
                Debug.Log("Compare: Sao iguais");
                SceneManager.LoadScene("Explicação");
            }
            else
            {
                Debug.Log("Compare: Nao sao iguais");               
            }
        }
    }
}
