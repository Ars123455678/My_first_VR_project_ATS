using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Player : MonoBehaviour
{
	public static Player st;

	public Transform ts;
	public XRGrabInteractable xrGrabInteractable;

	public void Awake() {
		st = this;
		ts = transform;
	}
}
