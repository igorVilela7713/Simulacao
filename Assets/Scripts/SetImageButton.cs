using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetImageButton : MonoBehaviour{

  public Sprite pic;
  public SetImage imageChanger;

  public Button yourButton;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		imageChanger.ImageChange(pic);
	}

}
