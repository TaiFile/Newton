using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class MacaSpawnerCode : MonoBehaviour
{
    public GameObject maca;
    public GameObject abacaxi;
    public GameObject Melancia;
    public GameObject Uva;
    public GameObject Morango;
    public GameObject Pera;
    public GameObject Pessego;
    public GameObject Limao;
    public GameObject Banana;


    public bool pilhasIguais = false;
    public double delayDeSpawn = 0.8;
    private float timer;
    public float speed = 1000;
    public float maxEsq = -8;
    public float maxDir = 11;

    void Start()
    {
        
    }
    void Update()
    {
        if (timer < delayDeSpawn)
        {
            timer += Time.deltaTime;
        }
        else
        {
            transform.SetPositionAndRotation(new Vector3(Random.Range(maxEsq, maxDir), transform.position.y, transform.position.z), transform.rotation);
            spawnFruta(FrutaRandow());
            timer = 0;
        }

    }

    GameObject FrutaRandow()
    {
        GameObject fruta_escolhida;
        int num_randon = Random.Range(0,8);

        if(num_randon == 0){
            fruta_escolhida = Pera;
        }
        else if(num_randon == 1){
            fruta_escolhida = abacaxi;
        }
        else if(num_randon == 2){
            fruta_escolhida = Melancia;
        }
        else if(num_randon == 3){
            fruta_escolhida = Uva;
        }
        else if(num_randon == 4){
            fruta_escolhida = Pessego;
        }
        else if(num_randon == 5){
            fruta_escolhida = Banana;
        }
        else if(num_randon == 6){
            fruta_escolhida = Limao;
        }
        else if(num_randon == 7){
            fruta_escolhida = Morango;
        }
        else{
            fruta_escolhida = maca;
        }
        return fruta_escolhida;
    }
    void spawnFruta(GameObject fruta)
    {
        Instantiate(fruta, transform.position, transform.rotation);
    }

}
