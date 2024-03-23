using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireGiving : TurbinaComponent
{
	private Transform ts;
	private RotatingSpeedSlider slider;

	public float moveX = -1;
	public float moveY = 0;
	public float moveZ = 0;
 
	protected override void Start() {
		base.Start();
		ts = transform;
		slider = RotatingSpeedSlider.st; 	    
	}

	public void Update() {
		if (!isDropped)
			ts.Translate(new Vector3(moveX * Time.deltaTime * slider.GetValue(), moveY * Time.deltaTime * slider.GetValue() * 10, moveZ * Time.deltaTime * slider.GetValue()));
	}

	private void OnDrop() {
		isDropped = true;
	}
}