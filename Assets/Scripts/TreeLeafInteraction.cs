using UnityEngine;
using UnityEngine.EventSystems;

public class TreeLeafInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject infoCanvas;
    private TreeInfoLoader infoLoader;

    public string treeType; // �� Inspector ��Ϊÿ����Ҷ�������ֵ

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