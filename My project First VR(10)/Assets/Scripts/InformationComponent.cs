using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class InformationComponent : MonoBehaviour
{
    private GameObject textGo;
    private XRSimpleInteractable interactable;         
    
    public string componentName;

    private void Start()
    {
        textGo = transform.GetChild(0).gameObject;
        interactable = GetComponent<XRSimpleInteractable>();                    
        HideText(null);
        interactable.hoverEntered.AddListener(ShowText);
        interactable.hoverExited.AddListener(HideText); 
    } 

    public void ShowText(HoverEnterEventArgs f)
    {
        textGo.SetActive(true);
    }

    public void HideText(HoverExitEventArgs f)
    {
        textGo.SetActive(false);
    }
}