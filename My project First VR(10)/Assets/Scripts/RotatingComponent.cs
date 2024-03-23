using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RotatingComponent : TurbinaComponent
{
	private Transform ts;
	private RotatingSpeedSlider slider;

	public float rotateX = -5000;
	public float rotateY = 0;
	public float rotateZ = 0;
 
	protected override void Start() {
		base.Start();
		ts = transform;
		slider = RotatingSpeedSlider.st; 	    
	}

	public void Update() {
		if (!isDropped)
			ts.Rotate(new Vector3(rotateX * Time.deltaTime * slider.GetValue(), rotateY * Time.deltaTime * slider.GetValue() * 10, rotateZ * Time.deltaTime * slider.GetValue()));
	}

	private void OnDrop() {
		isDropped = true;
	}
}
