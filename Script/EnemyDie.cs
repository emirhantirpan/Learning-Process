using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    private void OnEnable()
    {
        Enemy.EnemyHealth += EnemyDead;
    }
    private void EnemyDead(int currentHealth)
    {
        if (currentHealth == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
