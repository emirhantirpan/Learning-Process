using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public GameObject characterStats;
    public GameObject characterStats2;
    public GameObject characterStatsP;
    public GameObject characterStatsQ;
    public GameObject characterStatsW;
    public GameObject characterStatsE;
    public GameObject characterStatsR;
    public GameObject characterStatsP2;
    public GameObject characterStatsQ2;
    public GameObject characterStatsW2;
    public GameObject characterStatsE2;
    public GameObject characterStatsR2;

    [SerializeField] private Button _firstChamp;
    [SerializeField] private Button _secondChamp;

    private void Start()
    {
        _firstChamp.onClick.AddListener(() => PanelController.instance.OpenPanel(characterStats));
        _secondChamp.onClick.AddListener(() => PanelController.instance.OpenPanel(characterStats2));
        
    }
    private void Update()
    {    
        PanelController.instance.OpenPanelWithKey(KeyCode.P, characterStatsP);
        PanelController.instance.OpenPanelWithKey(KeyCode.Q, characterStatsQ);
        PanelController.instance.OpenPanelWithKey(KeyCode.W, characterStatsW);
        PanelController.instance.OpenPanelWithKey(KeyCode.E, characterStatsE);
        PanelController.instance.OpenPanelWithKey(KeyCode.R, characterStatsR);

        PanelController.instance.OpenPanelWithKey(KeyCode.P, characterStatsP2);
        PanelController.instance.OpenPanelWithKey(KeyCode.Q, characterStatsQ2);
        PanelController.instance.OpenPanelWithKey(KeyCode.W, characterStatsW2);
        PanelController.instance.OpenPanelWithKey(KeyCode.E, characterStatsE2);
        PanelController.instance.OpenPanelWithKey(KeyCode.R, characterStatsR2);

        //PanelController.instance.ClosePanel(characterStatsP);
    }
   

}
