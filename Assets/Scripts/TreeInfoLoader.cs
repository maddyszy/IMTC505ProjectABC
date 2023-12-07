using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class TreeInfoLoader : MonoBehaviour
{
    public  TextMeshProUGUI infoText;
    public TextMeshProUGUI titleText;

    public void SetTreeInfo(string treeTag)
    {
        string textFilePath = "Texts/" + treeTag;
        //Debug.Log("Text File Path: " + textFilePath);
        var textFile = Resources.Load<TextAsset>(textFilePath);
        if (textFile != null)
        {
            infoText.text = textFile.text;
            titleText.text = AddSpacesToSentence(treeTag);
        }
        else
        {
            Debug.LogError("Text file not found for: " + treeTag);
        }
    }

    private static string AddSpacesToSentence(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        var newText = Regex.Replace(text, "([a-z])([A-Z])", "$1 $2");

        return char.ToUpper(newText[0]) + newText.Substring(1);
    }
}
