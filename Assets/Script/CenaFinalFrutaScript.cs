using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cf_FrutaScript : MonoBehaviour
{
    public float cf_deadzone;
    public Rigidbody2D cf_Rigidbody;
    public float cf_TaxaDeAceleracao = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        cf_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < cf_deadzone)
        {
            Destroy(gameObject);
        }
        cf_Rigidbody.gravityScale = 1f + 20 * cf_TaxaDeAceleracao;
    }
}
