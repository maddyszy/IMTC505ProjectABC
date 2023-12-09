using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class Info : MonoBehaviour
{
    public TextMeshProUGUI helpText;

    private bool isTextVisible;

    void Start()
    {
        Debug.Log("Load Info Button");
        helpText.gameObject.SetActive(false);
        isTextVisible = false;
    }

    public void ShowPopup()
    {
        Debug.Log("Showpopup");
        isTextVisible = !isTextVisible;

        if (isTextVisible)
        {
            helpText.gameObject.SetActive(true);
        }

        else
        {
            helpText.gameObject.SetActive(false);
        }

    }
}
