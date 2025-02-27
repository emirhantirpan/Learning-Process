using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour, IDamageable
{
    public void Explode(int damage)
    {
        DamageableObject.currentHealth -= damage;
        Destroy(gameObject);
    }
    public void Damage(int damage)
    {
        Explode(damage);
    }
}
