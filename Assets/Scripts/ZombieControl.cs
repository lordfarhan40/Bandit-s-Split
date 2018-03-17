using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieControl : MonoBehaviour {

    public GameObject go;
    NavMeshAgent agent;
    Animator anim;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(transform.position,go.transform.position)<3)
        {
            anim.SetBool("isNear", true);
            agent.Stop();
        }else
        {
            anim.SetBool("isNear", false);
            agent.Resume();
        }
        agent.SetDestination(go.transform.position);
	}
}
