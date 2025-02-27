using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public delegate void EnemyHealthStat(int health);
    public static event EnemyHealthStat EnemyHealth;

    public int currentHealth;
    public int maxHealth = 5000;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnemyHealth(TakeDamage());
        }
    }
    private int TakeDamage()
    {
        currentHealth -= 200;

        return currentHealth;
    }

}
