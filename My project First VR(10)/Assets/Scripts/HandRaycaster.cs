using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRaycaster : MonoBehaviour
{
	public Transform ts;

	private TurbinaComponent previous;

	public void Start() {

	}

	public void Update() {

		RaycastHit hit = Physics.Raycast(ts.position, ts.forward);	     
		hit.collider.GetComponent<TurbinaComponent>().ShowName();
	}
}
