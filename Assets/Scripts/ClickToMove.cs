using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour{
    // Start is called before the first frame update
    private Animator mAnimator;

    private UnityEngine.AI.NavMeshAgent mNavMashAgent;

    private bool mRunning = false;

    void Start()   {

        mAnimator = GetComponent<Animator>();
        mNavMashAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()    {

      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;

      if (Input.GetMouseButtonDown(0)) {

        if (Physics.Raycast(ray, out hit, 100)) {
          mNavMashAgent.destination = hit.point;
        }

      }

      if (mNavMashAgent.remainingDistance <= mNavMashAgent.stoppingDistance) {
        mRunning = false;
      }else{
        mRunning = true;
      }

      mAnimator.SetBool("running", mRunning);

    }
}
