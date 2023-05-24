using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SingManager : MonoBehaviour
{
    public static SingManager Instance;
    public static AbsScore score = new AbsScore(0);

    public event Action ValueChanged = delegate { };

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Incrase(int value)
    {
        value = Mathf.Abs(value);
        score.ModifyValue(value);
        Debug.Log(score.GetScore() + " | " + value);
        ValueChanged.Invoke();
    }
}
