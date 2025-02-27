using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int hp;

    public int Can
    {
        get { return hp; }
        set
        {
            if (hp < 0)
            {
                hp = 0;
            }
            if (hp > 5000)
            {
                hp = 5000;
            }
        }
    }
    private void Start()
    {
        Can = 5000;
        Debug.Log(Can);
    }
}
