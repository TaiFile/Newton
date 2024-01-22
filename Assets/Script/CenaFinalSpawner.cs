using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class SpawnerFinal : MonoBehaviour
{
    public GameObject maca1;
    public GameObject abacaxi1;
    public GameObject Melancia1;
    public GameObject Uva1;
    public GameObject Morango1;
    public GameObject Pera1;
    public GameObject Pessego1;
    public GameObject Limao1;
    public GameObject Banana1;

    public float cf_taxaDeSpawn = 1;
    private float cf_timer;
    public float cf_speed = 3001;
    public float cf_maxEsq = -8;
    public float cf_maxDir = 11;

    void Start()
    {
        
    }
    void Update()
    {
        if (cf_timer < cf_taxaDeSpawn)
        {
            cf_timer += Time.deltaTime;
        }
        else
        {
            transform.SetPositionAndRotation(new Vector3(Random.Range(cf_maxEsq, cf_maxDir), transform.position.y, transform.position.z), transform.rotation);
            cf_spawnFruta(cf_FrutaRandow());
            cf_timer = 0;
        }

    }

    GameObject cf_FrutaRandow()
    {
        GameObject cf_fruta_escolhida;
        int cf_num_randon = Random.Range(0,8);

        if(cf_num_randon == 0){
            cf_fruta_escolhida = maca1;
        }
        else if(cf_num_randon == 1){
            cf_fruta_escolhida = abacaxi1;
        }
        else if(cf_num_randon == 2){
            cf_fruta_escolhida = Melancia1;
        }
        else if(cf_num_randon == 3){
            cf_fruta_escolhida = Uva1;
        }
        else if(cf_num_randon == 4){
            cf_fruta_escolhida = Pessego1;
        }
        else if(cf_num_randon == 5){
            cf_fruta_escolhida = Banana1;
        }
        else if(cf_num_randon == 6){
            cf_fruta_escolhida = Limao1;
        }
        else if(cf_num_randon == 7){
            cf_fruta_escolhida = Morango1;
        }
        else{
            cf_fruta_escolhida = Pera1;
        }
        return cf_fruta_escolhida;
    }
    void cf_spawnFruta(GameObject cf_fruta)
    {
        Instantiate(cf_fruta, transform.position, transform.rotation);
    }

}
