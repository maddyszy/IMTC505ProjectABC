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

    void Start()
    {
        /**
        Canvas canvas = GetComponent<Canvas>();
        if (canvas.renderMode == RenderMode.ScreenSpaceCamera || canvas.renderMode == RenderMode.WorldSpace)
        {
            canvas.worldCamera = Camera.main;
        }
        **/
        treeTexts.Add("CrabApple", "Assets/Texts/CrabApple.txt");
        treeTexts.Add("WhiteOak", "Assets/Texts/WhiteOak.txt");
        /**
        GameObject parentObject = transform.parent.gameObject;
        if (parentObject != null)
        {
            string parentTag = parentObject.tag;
            Debug.Log("Parent GameObject tag: " + parentTag);
            ShowTreeInfo(parentTag);
        }
        else
        {
            Debug.LogError("Parent GameObject not found");
        }
        **/
        ShowTreeInfo("CrabApple");
    }

    public void ShowTreeInfo(string treeTag)
    {
        if (treeTexts.TryGetValue(treeTag, out string filePath))
        {
            string textContent = File.ReadAllText(filePath);
            infoText.text = textContent;
            titleText.text = AddSpacesToSentence(treeTag);
        }
        else
        {
            Debug.LogError("Tree info file not found for: " + treeTag);
        }
    }

    public static string AddSpacesToSentence(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        // 使用正则表达式在大写字母前添加空格
        var newText = Regex.Replace(text, "([a-z])([A-Z])", "$1 $2");

        // 确保结果字符串首字母大写
        return char.ToUpper(newText[0]) + newText.Substring(1);
    }
}
