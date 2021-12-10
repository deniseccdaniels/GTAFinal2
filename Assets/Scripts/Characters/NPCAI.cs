using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
    //Where the NPC walk to 
    public GameObject desinationPoint;
    // Declare type 
    NavMeshAgent theAgent;

	void Start () {
        //Attach the component
        theAgent = GetComponent<NavMeshAgent>();
	}

	void Update () {
        //Set the destination of where the agent needs
        theAgent.SetDestination(desinationPoint.transform.position);
	}
}
