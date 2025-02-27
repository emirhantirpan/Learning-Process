using System;
using System.Collections.Generic;
using UnityEngine;
using static MainInterfaceMethod;

public class Ödev : MonoBehaviour
{
    public List<string> _gameObjectList = new List<string>
    {
        "1","2","3","4","5","6","7","8","9","10"
    };
    public List<string> _listOfGameObjects = new List<string>();
    public int howMany;

    private string GetRandomObject(List<string> list)
    {
        int randomIndex = UnityEngine.Random.Range(0, list.Count);
        return list[randomIndex];
    }
    public void SelectRandomGameObject(int count)
    {
        _listOfGameObjects.Clear();
        List<string> tempList = new List<string>(_gameObjectList);

        for(int i = 0; i < count; i++)
        {

            string randomGameObject = GetRandomObject(tempList);
            _listOfGameObjects.Add(randomGameObject);
            tempList.Remove(randomGameObject);
        }
    }
    public void SelectedObjects(int count)
    {
        SelectRandomGameObject(count);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SelectedObjects(howMany);
        }
        
    }

    
}
