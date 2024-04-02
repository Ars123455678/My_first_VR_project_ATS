using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatingSpeedSlider : MonoBehaviour
{
	public static RotatingSpeedSlider st; 

	public Slider slider;

	public void Awake() {
		st = this;
		slider = GetComponent<Slider>();
	}

	public float GetValue() {
		return slider.value;
	}
}
