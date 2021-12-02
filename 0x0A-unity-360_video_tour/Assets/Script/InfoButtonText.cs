using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButtonText : MonoBehaviour
{
    public GameObject infoText;
    bool visible = false;

    public void ToggleInfoText()
    {
        if (visible)
        {
            infoText.SetActive(false);
            visible = false;
        }
        else
        {
            infoText.SetActive(true);
            visible = true;
        }
    }
}
