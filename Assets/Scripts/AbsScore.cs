using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsScore 
{
    private int score;

    public AbsScore(int initScore)
    {
        score = initScore;
    }
    public void ModifyValue(int mod)
    {
        score += mod;
    }
    public void ResetScore()
    {
        score = 0;
    }

    public int GetScore()
    {
        return score;
    }
}
