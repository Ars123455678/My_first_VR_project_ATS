using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelGivingScript : MonoBehaviour
{
    public GameObject prefab;
    public Transform pos;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;

    private List<GameObject> objects = new List<GameObject>();                                                                                        
    public void CreateObject()
    {
        GameObject newObj = Instantiate(prefab, pos.position, pos.rotation);
        objects.Add(newObj);
    }
    public void CreateObject1()
    {
        GameObject newObj = Instantiate(prefab, pos1.position, pos1.rotation);
        objects.Add(newObj);
    }
    public void CreateObject2()
    {
        GameObject newObj = Instantiate(prefab, pos2.position, pos2.rotation);
        objects.Add(newObj);
    }
    public void CreateObject3()
    {
        GameObject newObj = Instantiate(prefab, pos3.position, pos3.rotation);
        objects.Add(newObj);
    }
}
