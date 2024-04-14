using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicController : MonoBehaviour
{
    public GameObject prefab;
    public void KinematicOn()
    {
        Rigidbody[] rbs = prefab.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody r in rbs) {
        r.isKinematic = false;
        }
    }
}
