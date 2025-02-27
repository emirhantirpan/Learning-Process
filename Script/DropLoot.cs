using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropLoot : MonoBehaviour
{
    public GameObject[] loot;

    private int lootCount;

    private void OnEnable()
    {
        Enemy.EnemyHealth += Drop;
    }
    private int RandomNumber()
    {
        lootCount = Random.Range(0, loot.Length);
        return lootCount;
    }
    private void Drop(int currentHealth)
    {
        if (currentHealth <= 0)
        {
            Instantiate(loot[RandomNumber()], transform.position, Quaternion.identity);
        }
    }
}
