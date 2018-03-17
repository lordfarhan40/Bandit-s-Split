using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public static double health;
    public UnityEngine.UI.Slider slider;
    public static Animator anim;

    bool isDead;

    void Start()
    {
        isDead = false;
        anim = GetComponent<Animator>();
        health = 100.0;
    }

    public void Death()
    {
        if (isDead)
            return;
        anim.SetTrigger("isDead");
        StartCoroutine("DieScreen");
        isDead = true;
    }

    public void Damage()
    {
        if (health < 0)
            return;
        health -= 0.3;
        if (health < 0)
        {
            Death();
        }
        slider.value -=0.3f;
    }

    IEnumerator DieScreen()
    {
        yield return new WaitForSeconds(3);

        Application.LoadLevel(2);
    }
}