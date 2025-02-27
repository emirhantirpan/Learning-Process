using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : KalıtımAnaSınıf
{
    public override void Walk()
    {
        Debug.Log(isim + " sallana sallana y�r�yor.");
    }
    public override void Initialize()
    {
        isim = "Golem";
        health = 100;
        level= 5;
    }
    /*private void Update()
    {
        Move();
    }*/
    /*public override void Move()
    {
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3 (0, 0, vertical);
        transform.Translate(direction * Time.deltaTime * 5f);
        Debug.Log("Golem y�r�yor.");
    }*/
}
