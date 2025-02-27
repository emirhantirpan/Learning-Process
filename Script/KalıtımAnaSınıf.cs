using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using TMPro;

public class KalıtımAnaSınıf : MonoBehaviour
{
    public string isim;
    public int health;
    public int level;

    public GameObject _panel;
    public TMP_Text enemyName;
    public TMP_Text enemyHealth;
    public TMP_Text enemyLevel;
    public void Start()
    {
        _panel.SetActive(false);
        Initialize();
        TextPanel();
    }
    public virtual void Walk()
    {
        Debug.Log(isim + " yürüyor.");
    }
    public virtual void Initialize() 
    {
        
    }
    public virtual void TextPanel()
    {
        enemyName.text = isim;
        enemyHealth.text = health.ToString();
        enemyLevel.text = level.ToString();
    }
    public virtual void PanelOpener()
    {

        _panel.SetActive(true);
    }
    public void OnMouseOver()
    {
        PanelOpener();
    }
    public void OnMouseExit()
    {
        _panel.SetActive(false);
    }
}
