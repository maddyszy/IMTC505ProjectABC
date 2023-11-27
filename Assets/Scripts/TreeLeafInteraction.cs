using UnityEngine;
using UnityEngine.EventSystems;

public class TreeLeafInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject infoCanvas;
    private TreeInfoLoader infoLoader;

    public string treeType; // 在 Inspector 中为每个树叶设置这个值

    /**
    public void OnPointerClicked()
    {
        infoLoader = infoCanvas.GetComponent<TreeInfoLoader>();
        infoLoader.ShowTreeInfo("CrabApple");
    }
    **/

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Pointer clicked");
    }
}