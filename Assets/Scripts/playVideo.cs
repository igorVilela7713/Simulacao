using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playVideo : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
    public GameObject video;
    
    public void PlayVideo()  {
        video.SetActive(true);
        yourButton.gameObject.SetActive(false);
    }

    public void StopVideo()  {
        video.SetActive(false);
        //yourButton.gameObject.SetActive(true);
    }
}
