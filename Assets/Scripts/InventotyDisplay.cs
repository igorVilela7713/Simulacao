using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventotyDisplay : MonoBehaviour{

  Text displayText;

  void  Awake(){
    displayText = GetComponent<Text>();
    displayText.text = "Inventario Vazio";
  }

  public void UpdateDisplay(){
    string displayName;
    if (GameManager.ins.itemHeld != null) {
      displayName = GameManager.ins.itemHeld.itemName;
    }else {
      displayName = "Vazio";
    }
    displayText.text = "Inventario: " + displayName;
  }


}
