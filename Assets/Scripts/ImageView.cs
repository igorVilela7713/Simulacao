using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageView : Interactable{

  public Sprite pic;
  public Button yourButton;

    public override void Interact(){

      GameManager.ins.ivCanvas.Activate(pic);
      yourButton.gameObject.SetActive(true);
    }

}
