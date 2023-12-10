using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Exit : MonoBehaviour
{
    private Button quitButton;

    void Start()
    {
        Debug.Log("Exit Button Load");
    }

    public void QuitGame()
    {
        Debug.Log("Prepare to exit....");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
