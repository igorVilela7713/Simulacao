using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextFadeOut : MonoBehaviour
{
    // Start is called before the first frame update
    public Text displayText;
    void Start()
    {
        Invoke("UpdateDisplay", 10f);
        
    }


    public void UpdateDisplay(){

    string displayName= " ";
    displayText.text =  displayName;
  }
}
