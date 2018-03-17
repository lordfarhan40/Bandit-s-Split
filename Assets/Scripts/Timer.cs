using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public int gameTimer = 1 * 60;

    private float nextActionTime;
    private float period = 1;
    private Animator anim;
    public Text GameTimer;

    // Use this for initialization
    void Start()
    {
        gameTimer=300;
        anim = GetComponent<Animator>();
    }

    void diePlayer()
    {
        GetComponent<PlayerMain>().Death();
    }



    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            gameTimer--;
            gameTimer = 0 > gameTimer ? 0 : gameTimer;
            print("Time: " + gameTimer);
            GameTimer.text = "Time: " + gameTimer;
            if (gameTimer <= 0)
            {
                diePlayer();
            }
        }
    }
}
