using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCollorChange : MonoBehaviour{

  public Button button;
  private bool clicked = true;
  public bool required = false;

  void Start () {
    Button btn = button.GetComponent<Button>();
    btn.onClick.AddListener(TaskOnClick);
  }

  void TaskOnClick(){
      if (clicked) {
        TurnGreen();
        clicked = false;
      }else{
        TurnWhite();
        clicked = true;
      }

	}

  public void TurnGreen()
     {
         ColorBlock colors = button.colors;
         colors.normalColor = new Color32(112, 184, 94, 255);
         colors.highlightedColor = new Color32(100, 200, 100, 255);
         button.GetComponent<Image>().color = new Color32(112, 200, 94, 255);
         button.colors = colors;
     }

     public void TurnWhite()
     {
         ColorBlock colors = button.colors;
         colors.normalColor = Color.white;
         colors.highlightedColor = new Color32(225, 225, 225, 255);
         button.GetComponent<Image>().color = new Color32(225, 225, 225, 255);
         button.colors = colors;
     }

     public bool isClieck(){
       return clicked;

     }
}
