using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour{
  public int sceneToLoad;
  void  OnTriggerEnter(){
    SceneManager.LoadScene(sceneToLoad);
  }

}
