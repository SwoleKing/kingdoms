using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveUnit : MonoBehaviour {

    public RaycastHit rayHit;
    public NavMeshAgent navMeshAgent;
    public Select selectScript;

    // Use this for initialization
    void Awake () {
        navMeshAgent = GetComponent<NavMeshAgent>();
        selectScript = GetComponent<Select>();
    }
	
	// Update is called once per frame
	void Update () {
        if (selectScript.isSelected)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetButtonDown("Fire2"))
            {
                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.collider.CompareTag("Tile"))
                    {
                        navMeshAgent.destination = hit.point;
                        navMeshAgent.isStopped = false;
                    }
                }
            }
        }
    }
}
