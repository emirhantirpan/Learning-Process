using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DictionarySenaryo_1 : MonoBehaviour
{
    public Dictionary<string, int> inventory = new Dictionary<string, int>();

    [SerializeField] private Text _text;

    private void Start()
    {
        AddToList();
        DisplayStats();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IfTakeItem("Sword"); 
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            IfDropItem("Sword");
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            IfTakeItem("Shield"); 
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            IfDropItem("Shield"); 
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            IfTakeItem("Berries");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            IfDropItem("Berries");
        }
    }
    private void AddToList()
    {
        inventory.Add("Sword", 0);
        inventory.Add("Shield", 0);
        inventory.Add("Berries", 0);
    }
    private void DisplayStats()
    {
        _text.text = "";
        foreach (var item in inventory)
        {
            _text.text += $"{item.Key}: {item.Value}\n";
        }
    }
    private void IfTakeItem(string key)
    {
        if (inventory.ContainsKey(key))
        {
            inventory[key]++;
            DisplayStats();
        }
    }
    private void IfDropItem(string key)
    {
        if (inventory.ContainsKey(key) && inventory[key] > 0)
        {
            inventory[key]--;
            DisplayStats();
        }
    }
}
