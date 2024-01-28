using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewtonFinal : MonoBehaviour
{
    public float input;
    public float speed = 10f;
    public Rigidbody2D rbb;
    public CircleCollider2D cll;
    public bool win;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");
        rbb.velocity = new Vector2(input * speed * Time.fixedDeltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D test)
    {

        if (test.gameObject.CompareTag("FMaca"))
        {
            Debug.Log("Pegou maca");
            win = true;
        }
        else if (test.gameObject.CompareTag("FAbacaxi"))
        {
            Debug.Log("Pegou abacaxi");
            win = false;
        }
        else if (test.gameObject.CompareTag("FMelancia"))
        {
            Debug.Log("Pegou melancia");
            win = false;
        }
        else if (test.gameObject.CompareTag("FPessego"))
        {
            Debug.Log("Pegou pessego");
            win = false;
        }
        else if (test.gameObject.CompareTag("FMorango"))
        {
            Debug.Log("Pegou morango");
            win = false;
        }
        else if (test.gameObject.CompareTag("FLimao"))
        {
            Debug.Log("Pegou Limao");
            win = false;
        }
        else if (test.gameObject.CompareTag("FUva"))
        {
            Debug.Log("Pegou Uva");
            win = false;
        }
        else if (test.gameObject.CompareTag("FPera"))
        {
            Debug.Log("Pegou Pera");
            win = false;
        }
        else if (test.gameObject.CompareTag("Fbanana"))
        {
            Debug.Log("Pegou Banana");
            win = false;
        }

        if (win)
        {
            SceneManager.LoadScene("Win_Video");
        }
        else
        {
            SceneManager.LoadScene("Defeat_Video");
        }

    }
}