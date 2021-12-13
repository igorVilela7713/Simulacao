using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : Interactable{

  public Item2 myItem;

  public override void Interact(){
    GameManager.ins.itemHeld = myItem;
    GameManager.ins.invDisplay.UpdateDisplay();
  }

}
