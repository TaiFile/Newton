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
    public bool soltouMaca = false;

    public float delayDeSpawn = 3;
    private float timer;
    public float speed = 3010;
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
            
            if(pilhasIguais) 
            {
                spawnFruta(maca);
                pilhasIguais = false;
                soltouMaca = true;
            }
            else if (!soltouMaca)
            {
                spawnFruta(FrutaRandow());
            }
            timer = 0;
        }

    }

    GameObject FrutaRandow()
    {
        GameObject fruta_escolhida;
        int num_randon = Random.Range(0,8);

        if(num_randon == 0){
            fruta_escolhida = maca;
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
            fruta_escolhida = Pera;
        }
        return fruta_escolhida;
    }
    void spawnFruta(GameObject fruta)
    {
        Instantiate(fruta, transform.position, transform.rotation);
    }

}
