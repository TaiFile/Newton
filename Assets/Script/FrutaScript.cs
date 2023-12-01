using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrutaScript : MonoBehaviour
{
    public float deadzone;
    public Rigidbody2D Rigidbody;
    public float AceleracaoGravidade = 1;
    private int frutasContadas;
    private Pilha pilhaAtual;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody.gravityScale = AceleracaoGravidade * (frutasContadas > 0 ? frutasContadas : 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadzone)
        {
            Destroy(gameObject);
        }
    }

    void AddFrutasContadas(int valor)
    {
        frutasContadas += valor;
    }
    void SubFrutasContadas(int valor)
    {
        frutasContadas -= valor;
    }
}
