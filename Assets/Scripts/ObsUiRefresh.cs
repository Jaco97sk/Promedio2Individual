using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObsUiRefresh : MonoBehaviour
{
    //Drag n drop on Inpsector
    public Text txt;

    private void OnEnable()
    {
        if (SingManager.Instance)
        {
            SingManager.Instance.ValueChanged += RescribeText;
        }
    }

    private void OnDisable()
    {
        if (SingManager.Instance)
        {
            SingManager.Instance.ValueChanged -= RescribeText;
        }
    }

    private void RescribeText()
    {
        txt.text = "¡" + SingManager.score.GetScore() + "!";
    }
}
