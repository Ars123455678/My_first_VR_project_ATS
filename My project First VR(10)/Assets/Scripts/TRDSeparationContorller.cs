using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TRDSeparationContorller : MonoBehaviour
{
    public float setDistance = 5;

    private Dictionary<Transform, Vector3> positionsMap = new Dictionary<Transform, Vector3>();
    private Dictionary<Transform, Quaternion> rotationsMap = new Dictionary<Transform, Quaternion>();

    private void Start()
    {
        Transform myts = transform;
        foreach (Transform ts in myts)
        {
            positionsMap.Add(ts, ts.position);
            rotationsMap.Add(ts, ts.rotation);
            ts.GetComponent<XRGrabInteractable>().selectExited.AddListener(OnSelectExited);
        }
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        Transform ts = args.interactableObject.transform;
        if (Vector3.Distance(ts.position, transform.position) < setDistance)
        { 
            ts.position = positionsMap[ts];
            ts.rotation = rotationsMap[ts];
        }
    }
}
