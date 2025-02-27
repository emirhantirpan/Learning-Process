using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DictionarySenaryo_2 : MonoBehaviour
{
    public Dictionary<string, int> characterHealth = new Dictionary<string, int>();

    [SerializeField] private Text _text;

    private void Start()
    {
        AddToList();
        DisplayStats();
    }
    private void AddToList()
    {
        characterHealth.Add("MainHero", 1000);
        characterHealth.Add("Enemy1", 100);
        characterHealth.Add("Enemy2", 200);
        characterHealth.Add("Enemy3", 300);
    }
    private void DisplayStats()
    {
        _text.text = "";
        foreach (var item in characterHealth)
        {
            _text.text += $"{item.Key}: {item.Value}\n";
        }
    }
    private void TakeDamage(string character, int damage)
    {
        if (characterHealth.ContainsKey(character))
        {
            characterHealth[character] -= damage;
            if (characterHealth[character] < 0)
            {
                characterHealth[character] = 0;
            }
            DisplayStats();
        }
    }
    private void HealCharacter(string character, int heal)
    {
        if (characterHealth.ContainsKey(character))
        {
            characterHealth[(character)] += heal;
            DisplayStats();
        }
    }
}

// düşman ana sınıfı oluştur. 3 tane farklı alt sınıf içerecek. yürüme komutunda farklılaşıtor. 
// golem sallana sallana yürür. zombi topal yürür. goblin zıplayarak gider. yürüme kodu ana sınıfta virtual olacak. düşmanlar yürüryor.