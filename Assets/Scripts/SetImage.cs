using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetImage : MonoBehaviour{

  public Image imageHolder;

  public void ImageChange(Sprite pic){
    imageHolder.sprite = pic;
  }

}
