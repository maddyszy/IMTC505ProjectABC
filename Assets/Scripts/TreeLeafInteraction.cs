using UnityEngine;
using UnityEngine.EventSystems;

public class TreeLeafInteraction : MonoBehaviour
{
    public GameObject panelPrefab;
    private GameObject panelInstance;
    private PlayAudioOnCollision audioSource;

    private string treeType;

    void Start()
    {
        panelInstance = Instantiate(panelPrefab);
        treeType = gameObject.tag;
        //Debug.Log("Tree Type: " + treeType);
        audioSource = gameObject.GetComponent<PlayAudioOnCollision>();
        panelInstance.GetComponent<TreeInfoLoader>().SetTreeInfo(treeType);
        panelInstance.GetComponent<AudioPlayer>().SetAudioSource(audioSource);
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