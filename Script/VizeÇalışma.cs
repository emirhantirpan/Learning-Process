using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class VizeÇalışma : MonoBehaviour
{
    /*An example for using Method Overloading and Enum together

    public WeaponType weapon;
    public enum WeaponType
    {
        Sword,
        Bow,
        MagicWand
    }
    private void Start()
    {
        Attack(WeaponType.Sword, 20);
        Attack(WeaponType.Bow, 10);
        Attack(WeaponType.MagicWand, 15);
    }
    private void Attack(WeaponType weapon)
    {
        switch(weapon)
        {
            case WeaponType.Sword:
                Debug.Log("Sword");
                break;
            case WeaponType.Bow:                                                                NONE
                Debug.Log("Bow");
                break;
            case WeaponType.MagicWand:
                Debug.Log("MagicWand");
                break;
        }
    }
    private void Attack(WeaponType weapon, float damage)
    {
        switch(weapon) 
        {
            case WeaponType.Sword:
                Debug.Log("Sword's" + damage.ToString());
                break; 
            case WeaponType.Bow:
                Debug.Log("Bow's" + damage.ToString());
                break;
            case WeaponType.MagicWand:
                Debug.Log("MagicWand's" + damage.ToString());
                break;
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------

    /*In Singleton Design Patern you will be able to use the script in another scripts and it will make you more comfortable with it

    public static VizeÇalışma instance;

    private void Awake()
    {
        instance = this;
    }
    public void OpenPanel(GameObject panel) // Example
    {                                                                                               DONE
        panel.SetActive(true);
    }
    public void OpenPanelWithKey(KeyCode key, GameObject panel)
    {
        if (Input.GetKey(key))
        {
            OpenPanel(panel);
        }
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------

    /*Get-Set Example

    private int hp;

    public int Health
    {
        get { return hp; }
        set
        {
            if (hp < 0)
            {
                hp = 0;
            }
            else if (hp > 5000)                                     DONE
            {
                hp = 100;
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp = 5000;
            Debug.Log(hp);
        }
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------

    /*Dictionary Example
    You should make 3 enemy example and provide their health statements
    
    public Dictionary<string, int> state = new Dictionary<string, int>();
    public Text text;

    private void Start()
    {
        AddToList();
        DisplayStats();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage("Skeleton", 20);
            TakeDamage("Zombie", 50);
            TakeDamage("Creeper", 60);                                                      DONE
            DisplayStats();
        }
    }
    public void AddToList()
    {
        state.Add("Skeleton", 100);
        state.Add("Zombie", 150);
        state.Add("Creeper", 200);
    }
    public void DisplayStats()
    {
        text.text = "";
        foreach (var health in state)
        {
            text.text = $"{health.Key}" + $"{health.Value}";
        }
    }
    public void TakeDamage(string enemy, int damage)
    {
        if (state.ContainsKey(enemy))
        {
            state[enemy] -= damage;
            if (state[enemy] < 0)
            {
                state[enemy] = 0;
            }
        }
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------

    /*enum/GameManager Example
    You should make a statement for game difficulty and as game get harder enemy number should increase

    public GameObject enemy;
    public GameState state;
    private void Start()
    {
        UpdateGameState(state);
    }
    private void UpdateGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.Easy:
                GameDifficulty(enemy, 5);
                break;
            case GameState.Normal:
                GameDifficulty(enemy, 10);                                              DONE
                break;
            case GameState.Hard:
                GameDifficulty(enemy, 20);
                break;
        }
    }
    public enum GameState
    {
        Easy,
        Normal,
        Hard
    }
    private void GameDifficulty(GameObject enemy, int _enemyCounter)
    {
        for (int i = 0; i < _enemyCounter; i++)
        {
            Instantiate(enemy);
        }
    }*/

    //-------------------------------------------------------------------------------------------------------------------------------------

    /*Moethod Overloading Example
    First function should instantiate an object, second should instantiate 5 objects, third should instantiate random number of objects from a list

    private void Add(List<GameObject> thing)
    {
        Instantiate(thing[1]);
    }
    private void Add(List<GameObject> thing, int number)
    {
        for (int i = 0; i < number; i++)                                                        DONE
        {
            Instantiate(thing[number]);
        }
    }
    private void Add(List<GameObject> thing, int start , int end)
    {
        for (int i = 0; i < UnityEngine.Random.Range(start, end); i++)
        {
            Instantiate(thing[UnityEngine.Random.Range(start, end)]);
        }
    }*/
}