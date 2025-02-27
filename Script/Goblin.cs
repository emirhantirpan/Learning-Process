using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : KalıtımAnaSınıf
{
    public override void Walk()
    {
        Debug.Log(isim + " z�playarak y�r�yor.");
    }
    public override void Initialize()
    {
        isim = "Goblin";
        health = 1000;
        level = 8;
    }
    /*private void Update()
    {
        Move();
    }*/
    /*public override void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * Time.deltaTime * 5f);
        Debug.Log("Goblin y�r�yor.");
        
    }*/
}
