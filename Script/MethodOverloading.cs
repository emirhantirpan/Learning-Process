using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverloading : MonoBehaviour
{
    private void Start()
    {
        Write("Berat",20,50);


        /*Write(0);
        Write(1,100,"Berat");*/
    }
    private string Write(string name)
    {
        Debug.Log(name);
        return name;
    }
    private int Write(string name,int count)
    {
        for (int i = 0; i < count; i++)
        {
            Debug.Log(name);
        }
        return count;
    }
    private void Write(string name, int start,  int end)
    {
        for (int i = start; i < end; i++)
        {
            if (start % 2 == 0)
            {
                Write(name);
            }
        }
    }
}
