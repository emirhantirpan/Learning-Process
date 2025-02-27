using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverloadingController : MonoBehaviour
{
    private void Start()
    {
       
    }
    private void Add(GameObject thing)
    {
        Instantiate(thing);
    }
    private void Add(GameObject thing, int number)
    {
        for (int i = 0;i < number; i++)
        {
            Instantiate(thing);
        }
    }
    private void Add(List<GameObject> thing, int start, int end)
    {
        for (int i = 0; i < UnityEngine.Random.Range(start, end); i++)
        {
            Instantiate(thing[UnityEngine.Random.Range(start, end)]);
        }
    }
    private void Add(List<GameObject> thing, int start, int end, bool isIt)
    {
        if (isIt == true)
        {
            for (int i = 0; i < UnityEngine.Random.Range(start, end); i++)
            {
                Instantiate(thing[UnityEngine.Random.Range(start, end)]);
            }
        }
        else
        {
            for (int i = start; i < end; i++)
            {
                Instantiate(thing[UnityEngine.Random.Range(start, end)]);
            }
        }
    }
}
