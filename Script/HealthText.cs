using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthText : MonoBehaviour
{
    public TMP_Text _text;

    private void OnEnable()
    {
        Enemy.EnemyHealth += Health;
    }
    private void Health(int currentHealth)
    {
        _text.text = currentHealth.ToString();
    }
    private void OnDisable()
    {
        Enemy.EnemyHealth -= Health;
    }
}
