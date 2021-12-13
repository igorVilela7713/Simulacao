using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class Node : MonoBehaviour{

    public Transform cameraPosition;
    public List<Node> reachableNodes = new List<Node>();
    public Texture2D cursorArrow;
    public Texture2D cursorInteract;

    [HideInInspector]
    public Collider col;


    // Start is called before the first frame update
    void Start()    {

      col = GetComponent<Collider>();

    }

    void OnMouseDown(){
      Arrive();
    }

    public virtual void Arrive (){

      if (GameManager.ins.currentNode != null) {
        GameManager.ins.currentNode.Leave();
      }

      GameManager.ins.currentNode = this;

      //Sequence seq = DOTween.Sequence();
      //seq.Append(Camera.main.transform.DOMove(cameraPosition.position, 0.75f));
      //seq.Join(Camera.main.transform.DORotate(cameraPosition.rotation.eulerAngles, 0.75f));
      //GameManager.ins.rig.AlingTo(cameraPosition);

      if (col != null) {
        col.enabled = false;
      }

      SetReachableNodes(true);
    }

    public virtual void Leave(){

      SetReachableNodes(false);

    }

    public void SetReachableNodes(bool set){
      foreach (Node node in reachableNodes) {
        if (node.col != null) {
          node.col.enabled = set;
        }
      }
    }

    void OnMouseEnter(){
      Cursor.SetCursor(cursorInteract, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit(){
      Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }


}
