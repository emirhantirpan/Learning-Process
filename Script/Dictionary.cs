using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class StatManager : MonoBehaviour
{
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    [SerializeField] private Button _increase;
    [SerializeField] private Button _decrease;
    [SerializeField] private Text _text;

    private void Start()
    {
        AddToList();

        _increase.onClick.AddListener(() => IncreaseButton("Health"));
        _decrease.onClick.AddListener(() => DecreaseButton("Health"));

        DisplayStats();
    }

    private void AddToList()
    {
        stats.Add("Health", 100);
        stats.Add("Stamina", 100);
        stats.Add("Shield", 100);
        stats.Add("Power", 100);
    }

    private void DisplayStats()
    {
        _text.text = $" {stats["Health"]}\n" +
                     $" {stats["Stamina"]}\n" +
                     $" {stats["Shield"]}\n" +
                     $" {stats["Power"]}";
    }

    private void IncreaseButton(string key)
    {
        if (stats.ContainsKey(key))
        {
            stats[key] += 50;
        }
        if (stats[key] > 100)
        {
            stats[key] = 100;
        }
        DisplayStats();
    }

    private void DecreaseButton(string key)
    {
        if (stats.ContainsKey(key))
        {
            stats[key] -= 50; 
        }
        if (stats[key] < 0 )
        {
            stats[key] = 0;
        }
        DisplayStats();
    }
}
