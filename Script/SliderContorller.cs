using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderContorller : MonoBehaviour
{
    private float minValue = 0f;
    private float maxValue = 5000f;

    [SerializeField] private Image _fillImage;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        Enemy.EnemyHealth += SliderChange;
    }
    private void SliderChange(int currentHealth)
    {
        _slider.value = currentHealth;
        _slider.minValue = minValue;
        _slider.maxValue = maxValue;

        if (currentHealth <= minValue)
        {
            _fillImage.enabled = false;
        }
        if (currentHealth > maxValue && !_fillImage.enabled)
        {
            _fillImage.enabled = true;
        }
        if (currentHealth <= 5000 && currentHealth > 3000)
        {
            _fillImage.color = Color.green;
        }
        else if (currentHealth <= 3000 && currentHealth > 1000)
        {
            _fillImage.color = Color.yellow;
        }
        else if (currentHealth <= 1000 && currentHealth >= 0)
        {
            _fillImage.color = Color.red;
        }
    }
    
    private void OnDisable()
    {
        Enemy.EnemyHealth -= SliderChange;
    }
}
