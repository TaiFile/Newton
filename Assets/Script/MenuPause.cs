using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject painel_do_menu;
    void Start()
    {
        painel_do_menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            PausarJogo();
        }
    }

    private void PausarJogo(){
        // estiver funcionando ->pause
        if(Time.timeScale == 1){
            Time.timeScale = 0;
            painel_do_menu.SetActive(true);
        }else if(Time.timeScale == 0){
            Time.timeScale = 1;
            painel_do_menu.SetActive(false);
        }
        //pausado -> funcione
    }

    public void Continuar(){
        PausarJogo();
    }

    public void Voltar_Menu(){
        SceneManager.LoadScene("TelaInicial");
    }

    public void Config(){
        Debug.Log("Abrindo config");
    }
}
