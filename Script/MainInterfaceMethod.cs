using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class MainInterfaceMethod : MonoBehaviour
{
    public interface IDamageable
    {
        void Damage(int damage);
    }
}
    