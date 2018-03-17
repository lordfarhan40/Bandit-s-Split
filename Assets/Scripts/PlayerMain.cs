using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour {


    int health;
    // Use this for initialization
    Animator anim;
	void Start () {
        anim = GetComponent<Animator>();
        health = 100;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void damage()
    {
        Debug.Log("Hello");
        health -= 10;
        Debug.Log("" + health);

        if (health<=0)
        {
            anim.SetTrigger("isDead");
        }
    }
}
