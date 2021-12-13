using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinuarBtn : MonoBehaviour{
    // Start is called before the first frame update
    public Canvas atual;
    public Canvas proximo;
    public Button btn;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        atual.gameObject.SetActive(false);
        proximo.gameObject.SetActive(true);
	}
}
