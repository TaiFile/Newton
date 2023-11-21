using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class MacaSpawnerCode : MonoBehaviour
{
    public GameObject fruta;
    
    public float taxaDeSpawn;
    private float timer;
    public float speed;

    void Start()
    {
        ;// transform.position = new Vector2(Random.Range(-9, 11), 7);
    }
    void Update()
    {
        if (timer < taxaDeSpawn)
        {
            timer += Time.deltaTime;
        }
        else
        {
            transform.SetPositionAndRotation(new Vector3(Random.Range(-8, 11), transform.position.y, transform.position.z), transform.rotation);
            spawnFruta();
            timer = 0;
        }

    }

    void spawnFruta()
    {
        Instantiate(fruta, transform.position, transform.rotation);
    }
}
