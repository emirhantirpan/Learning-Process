using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSkill : Yetenek
{
    public ParticleSystem skill;
    private void Start()
    {
        slider.value = sliderValue;
        

        skillButton.onClick.AddListener(UseSkill);
    }
    public override void Skill()
    {
        skill.Play();

    }

    private void UseSkill()
    {
        
            Skill();
            StartCounter(2);
        
    }
}
