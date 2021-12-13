using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscolhaProcedimento : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas retirar;
    public Canvas atual;
    public Button retirarBtn;
    public Canvas colocar;
    public Button colocarBtn;

    public Button finalizarBtn;

    public Text texto;

    private int count = 0;
    void Start()
    {
        finalizarBtn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        if(count == 2){
            finalizarBtn.gameObject.SetActive(true);
            texto.text = "Continuar para a proxima cena";
        }
        
    }

    public void OnClickRetirar(){
      colocar.gameObject.SetActive(false);
      retirar.gameObject.SetActive(true);
      atual.gameObject.SetActive(false);
      retirarBtn.gameObject.SetActive(false);
      count += 1;
      Debug.Log(count);
    }

    public void OnClickColocar(){
      colocar.gameObject.SetActive(true);
      retirar.gameObject.SetActive(false);
      atual.gameObject.SetActive(false);
      colocarBtn.gameObject.SetActive(false);
      count += 1;
    }
}
