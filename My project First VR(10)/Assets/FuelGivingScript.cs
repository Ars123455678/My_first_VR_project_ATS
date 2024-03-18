using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelGivingScript : MonoBehaviour
{
    public GameObject prefab;
    public Transform pos;

    private List<GameObject> objects = new List<GameObject>();                                                                                        
    public void CreateObject()
    {
        GameObject newObj = Instantiate(prefab, pos.position, pos.rotation);
        objects.Add(newObj);
    }
}
