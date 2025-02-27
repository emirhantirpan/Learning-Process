using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public static PanelController instance;

    public bool anyPanelOpen = false;

    private void Awake()
    {
        instance = this;
    }
   
    public void OpenPanel(GameObject gameObject)
    {
        gameObject.SetActive(true);
        anyPanelOpen = true;
    }
    public void OpenPanelWithKey(KeyCode key,GameObject panel)
    {
        if (Input.GetKey(key))
        {
            OpenPanel(panel);
        }
        
    }
    /**public void ClosePanel(GameObject gameObject)
    {
        anyPanelOpen = !anyPanelOpen;
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }*/
}
