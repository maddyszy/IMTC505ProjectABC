using UnityEngine;
using UnityEngine.EventSystems;

public class TreeLeafInteraction : MonoBehaviour
{
    public GameObject panelPrefab;
    private GameObject panelInstance;

    private string treeType;

    /**
    public void OnPointerClicked()
    {
        infoLoader = infoCanvas.GetComponent<TreeInfoLoader>();
        infoLoader.ShowTreeInfo("CrabApple");
    }
    **/
    void Start()
    {
        panelInstance = Instantiate(panelPrefab);
        treeType = gameObject.tag;
        Debug.Log("Tree Type: " + treeType);
        panelInstance.GetComponent<TreeInfoLoader>().SetTreeInfo(treeType);
        panelInstance.SetActive(false);
    }

    public void OnMouseDown()
    {
        if (panelInstance != null && !panelInstance.activeSelf)
        {
            panelInstance.SetActive(true);
        }

    }
}