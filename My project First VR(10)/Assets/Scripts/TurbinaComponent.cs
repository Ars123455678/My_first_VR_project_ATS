using System.Collections;
using System.Collections.Generic;
using UnityEngine;		   
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class TurbinaComponent : MonoBehaviour
{
	public string componentName;
	public Text text;		  

	public bool isDropped;
	protected XRGrabInteractable grab;
	

	protected virtual void Start() {
		grab = GetComponent<XRGrabInteractable>();
	}

	public void ShowName() {
		text.text = componentName;
	}

	public void HideName() {
		text.enabled = false;
	}
}
