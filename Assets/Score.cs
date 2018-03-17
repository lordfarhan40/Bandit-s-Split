using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    static int score;
    // Use this for initialization
    public void Reset()
    {
        score = 0;
    }
    public void SetScore(int num)
    {
        score = num;
    }
    public int GetScore()
    {
        return score;
    }
}
