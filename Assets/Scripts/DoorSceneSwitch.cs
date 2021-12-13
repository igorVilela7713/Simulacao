using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneSwitch : Interactable{

    public int sceneToLoad;

    public override void Interact(){

      SceneManager.LoadScene(sceneToLoad);

    }
}
