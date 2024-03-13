using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TurbinaComponent : MonoBehaviour
{
	public bool isDropped;
	protected XRGrabInteractable grab;
	

	protected virtual void Start() {
		grab = GetComponent<XRGrabInteractable>();
	}
}
