using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ShootableObjects : MonoBehaviour
{
    public ParticleSystem effect;

    private int _weaponDamage = 10;
    private int _explosiveDamage = 20;
    private float _fireRate = 0.7f;
    private float _nextShotTime;

    [SerializeField] private InteractionController interactionController;

    public bool isSkillReady = true;
    public Slider slider;
    public float sliderValue = 0;

    private void Update()
    {
        if (CanShoot())
        {
            Shoot();
        }
    }
    private bool CanShoot()
    {
        return Input.GetButton("Fire1") && Time.time > _nextShotTime;
    }
    public void Shoot()
    {
        _nextShotTime = Time.time + _fireRate;
        StartCounter(_fireRate);

        if (interactionController != null && interactionController.PerformRaycast(out RaycastHit hit))
        {
            DamageableObject damageable = hit.collider.gameObject.GetComponent<DamageableObject>();
            if (damageable != null)
            {
                Debug.Log(_weaponDamage + " hasar aldý.");
                damageable.Hit(_weaponDamage);
                Instantiate(effect, hit.transform.position, Quaternion.identity);
            }

            Explosive explosive = hit.collider.gameObject.GetComponent<Explosive>();
            if (explosive != null)
            {
                Debug.Log("Varil patladý.");
                Debug.Log(_explosiveDamage + " hasar aldý.");
                explosive.Explode(_explosiveDamage);
                Instantiate(effect, hit.transform.position, Quaternion.identity);
            }
        }
    }
    public IEnumerator Counter(float counter)
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
    public void StartCounter(float time)
    {
        StartCoroutine(Counter(time));
    }
}
