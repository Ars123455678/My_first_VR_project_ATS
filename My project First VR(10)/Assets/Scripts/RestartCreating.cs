using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class RestartCreating : MonoBehaviour
{
    public GameObject plane;
    public GameObject plane1;
    public GameObject plane2;
    public GameObject plane3;
    public GameObject plane4;
    public GameObject plane5;
    public GameObject plane6;
    public GameObject plane7;
    public GameObject plane8;
    public GameObject plane9;
    public GameObject plane10;
    public GameObject plane11;
    public GameObject plane12;
    public GameObject plane13;
    public GameObject plane14;
    public GameObject plane15;

    public GameObject shift;

    public void HidePlanes() {
        plane.SetActive(false);
        plane1.SetActive(false);
        plane2.SetActive(false);
        plane3.SetActive(false);
        plane4.SetActive(false);
        plane5.SetActive(false);
        plane6.SetActive(false);
        plane7.SetActive(false);
        plane8.SetActive(false);
        plane9.SetActive(false);
        plane10.SetActive(false);
        plane11.SetActive(false);
        plane12.SetActive(false);
        plane13.SetActive(false);
        plane14.SetActive(false);
        plane15.SetActive(false);
    }
    public void ActiveXRGrab() {
        shift.GetComponent<XRGrabInteractable>().enabled = true;
    }
    
}
