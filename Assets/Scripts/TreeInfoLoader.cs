using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class TreeInfoLoader : MonoBehaviour
{
    public  TextMeshProUGUI infoText;
    public TextMeshProUGUI titleText;
    private Dictionary<string, string> treeTexts = new Dictionary<string, string>();

    /**
    void Awake()
    {
        treeTexts.Add("CrabApple", "Assets/Texts/CrabApple.txt");
        treeTexts.Add("WhiteOak", "Assets/Texts/WhiteOak.txt");
        //SetTreeInfo("CrabApple");
    }
    **/

    public void SetTreeInfo(string treeTag)
    {
        //Debug.Log("Tree Tag: " + treeTag);
        // show all items in treeTexts
        //foreach (KeyValuePair<string, string> kvp in treeTexts)
        //{
        //    Debug.Log("Key = " + kvp.Key + ", Value = " + kvp.Value);
        //}
        //if (treeTexts.TryGetValue(treeTag, out string filePath))
        //{
        //    string textContent = File.ReadAllText(filePath);
        //    infoText.text = textContent;
        //    titleText.text = AddSpacesToSentence(treeTag);
        //}
        //else
        //{
        //    Debug.LogError("Tree info file not found for: " + treeTag);
        //}
        string textFilePath = "Texts/" + treeTag;
        Debug.Log("Text File Path: " + textFilePath);
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
        
        string audioFilePath = "Audio/" + treeTag;
        Debug.Log("Audio File Path: " + audioFilePath);
        AudioClip audioClip = Resources.Load<AudioClip>(audioFilePath);
        if (audioClip != null)
        {
            AudioPlayer audioSource = gameObject.GetComponent<AudioPlayer>();
            if (audioSource != null)
            {
                audioSource.SetAudioClip(audioClip);
            }
        }
        else
        {
            Debug.LogError("Audio file not found for: " + treeTag);
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
