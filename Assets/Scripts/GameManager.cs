using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public static GameManager ins;
    public IVCanvas ivCanvas;
    public InventotyDisplay invDisplay;
    public Texture2D cursorArrow;
    public bool ter_maos_limpas;
    public bool ter_identificado_paciente;
    public bool ter_identificado_necessidade_troca_acesso;
    public bool ter_acessado_prontuario;
    public bool ter_selecionado_materiais;
    public bool ter_retirado_acesso_anterior;
    public bool ter_realizado_novo_acesso;
    public bool ter_descartado_materiais;

  //  [HideInInspector]
    public Node currentNode;
    public Item2 itemHeld;

    public CameraRing rig;

    void  Awake(){
      ins = this;
      ivCanvas.gameObject.SetActive(false);
      Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    void Update(){

      if (Input.GetMouseButtonDown(1) && currentNode.GetComponent<Prop>() != null) {
        if (ivCanvas.gameObject.activeInHierarchy) {
            ivCanvas.Close();
            return;
        }
        currentNode.GetComponent<Prop>().loc.Arrive();
      }

    }


}
