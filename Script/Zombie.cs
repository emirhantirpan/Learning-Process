using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : KalıtımAnaSınıf
{
    public override void Walk()
    {
        Debug.Log(isim + " topallayarak y�r�yor.");
    }
    public override void Initialize()
    {
        isim = "Zombie";
       health = 500;
        level = 4;
    }
    /*private void Update()
    {
        Move();
    }*/
    /*public override void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontal, 0, 0);
        transform.Translate(direction * Time.deltaTime * 5f);
        Debug.Log("Zombie y�r�yor.");
    }*/
}
