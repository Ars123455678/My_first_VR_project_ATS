using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Instruction : MonoBehaviour
{
    public GameObject prefabd;
    public GameObject prefaba;
    public GameObject prefaba1;
    public GameObject panel;
    public GameObject paneld;
    public void Diactive() {
        prefabd.GetComponent<XRGrabInteractable>().enabled = false;
        prefaba.GetComponent<XRGrabInteractable>().enabled = true;
        panel.SetActive(true);
    }
    public void Back() {
        paneld.SetActive(false);
        prefabd.GetComponent<XRGrabInteractable>().enabled = false;
        prefaba1.GetComponent<XRGrabInteractable>().enabled = true;
    }
}
