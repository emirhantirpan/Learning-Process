using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public abstract class Yetenek : MonoBehaviour
{
    public bool isSkillReady=true;
    public Button skillButton;
    public Slider slider;
    public float sliderValue = 0;
    public abstract void Skill();

    public IEnumerator Counter(int counter)
    {
        isSkillReady = false;
        Debug.Log(gameObject.name + "Skill kullanýlamaz.");
        yield return new WaitForSecondsRealtime(counter);
        slider.maxValue = counter;
        for (sliderValue = 0; sliderValue < counter; sliderValue += Time.deltaTime)
        {
            slider.value = sliderValue;
            yield return null;
        }
        isSkillReady = true;
        Debug.Log(gameObject.name + "Skill kullanýma aktif.");

    }
    public void StartCounter(int time)
    {
        StartCoroutine(Counter(time));
    }
}
