using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscolhasGame : MonoBehaviour{

    public List<ButtonCollorChange> buttons = new List<ButtonCollorChange>();
    public Button button;

    public Button continuar;
    ButtonCollorChange button1;
    private bool clicked = true;
    private int count = 0;

    void Start(){

    }

    void Update(){

      foreach (ButtonCollorChange btn in buttons) {
        if (!btn.isClieck()) {
            button1 = btn;
            count++;
        }
      }
      if (count == 1) {
        button.gameObject.SetActive(true);
      }else{
        button.gameObject.SetActive(false);
      }
      count= 0;

      //Debug.Log(count);

    }

    public void OnClick(){
        button1.gameObject.SetActive(false);
        buttons.Remove(button1);
        button.gameObject.SetActive(false);
        continuar.gameObject.SetActive(true);
	}

}


