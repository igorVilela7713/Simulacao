using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WashHands : Interactable{

  public Sprite pic;
  public Image imageHolder;


  public override void Interact(){
    imageHolder.sprite = pic;
  }



}
