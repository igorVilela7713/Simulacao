using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickGame : MonoBehaviour{

    public List<ButtonCollorChange> buttons = new List<ButtonCollorChange>();
    public Button button;
    private int count = 0;

    public Canvas material;
    public Canvas escolhas;

    void Start(){

    }

    void Update(){

      foreach (ButtonCollorChange btn in buttons) {
        if (!btn.isClieck() && btn.required) {
          count++;
        }
      }
      if (count >= 8) {
        button.gameObject.SetActive(true);
      }else{
        button.gameObject.SetActive(false);
      }
      count= 0;

    }


    public void OnClick(){
      material.gameObject.SetActive(false);
      escolhas.gameObject.SetActive(true);
    }
}
