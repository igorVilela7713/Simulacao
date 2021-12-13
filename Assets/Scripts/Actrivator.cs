using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

  public class Actrivator : MonoBehaviour{

    public GameObject tongue;
    public Text displayText;

  void Start ()
  {
    //  displayText = GetComponent<Text>();
      InvokeRepeating("TongueOut", 3f, 1f);
      Invoke("UpdateDisplay", 10f);
  }

  void TongueOut ()
  {
      tongue.SetActive(true);
      Invoke("TongueIn", 0.5f);
  }

  void TongueIn ()
  {
      tongue.SetActive(false);
  }

  public void UpdateDisplay(){

    string displayName= "Paciente do leito 2 chamando";
    displayText.text =  displayName;
  }


}
