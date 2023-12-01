using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiPIlhaScript : MonoBehaviour
{
    private Pilha pilha;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        pilha = GameObject.FindGameObjectWithTag("TADpilha").GetComponent<Pilha>();
        
        GameObject x; bool ok;

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Acionou Destroi");
            
            pilha.Desempilha(out x, out ok);
        }
    }
}
