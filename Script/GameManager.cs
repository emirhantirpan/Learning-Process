using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState state;
    public GameObject enemy;
    private int _enemyCounter = 5;


    private void Start()
    {
        UpdateGameState(state);
    }
    private void UpdateGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.Kolay:
                GameDifficulty(enemy, 5);
                break;
            case GameState.Orta:
                GameDifficulty(enemy, 10);
                break;
            case GameState.Zor:
                GameDifficulty(enemy, 20); 
                break;
        }
    }
    public enum GameState
    {
        Kolay,
        Orta,
        Zor
    }
    /*private void Easy()
    {
        for (int i = 0; i < _enemyCounter; i++)
        {
            Instantiate(enemy, RandomPosition(), Quaternion.identity);
        }
    }
    private void Medium()
    {
        for (int i = 0; i < _enemyCounter * 2; i++)
        {
            Instantiate(enemy, RandomPosition(), Quaternion.identity);
        }

    }
    private void Hard()
    {
        for (int i = 0; i < _enemyCounter * 4; i++)
        {
            Instantiate(enemy, RandomPosition(), Quaternion.identity);
        }
    }*/
    private void GameDifficulty(GameObject thing, int enemyCount)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Instantiate(thing, RandomPosition(), Quaternion.identity);
        }
    }
    private Vector3 RandomPosition()
    {
        int x;
        int y; 
        int z; 
        Vector3 pos;
        x = Random.Range(1, 20);
        y = Random.Range(1, 20);
        z = Random.Range(1, 20);
        pos = new Vector3(x, y, z);
        return pos;
    }
}
