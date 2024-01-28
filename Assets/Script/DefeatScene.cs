using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;
using UnityEngine.SceneManagement;

public class DefeatScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DelayedExecution());
    }

    IEnumerator DelayedExecution()
    {
        Debug.Log("Iniciando...");
        yield return new WaitForSeconds(10);  // Espera por 36 segundos
        Debug.Log("Terminado!");

        SceneManager.LoadScene("TelaInicial");
    }
}
