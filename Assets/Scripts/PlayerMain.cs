using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    public static double health;
    public UnityEngine.UI.Slider slider;
    public static Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        health = 100.0;
    }

    public void Damage()
    {
        if (health < 0)
            return;
        health -= 0.3;
        if (health < 0)
        {
            anim.SetTrigger("isDead");
            StartCoroutine("DieScreen");
        }
        slider.value = ((float)health) / 100;
    }

    IEnumerator DieScreen()
    {
        yield return new WaitForSeconds(3);

        Application.LoadLevel(2);
    }
}