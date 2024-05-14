using System.Collections;
using System.Collections.Generic;
using UnityEngine;		   
using UnityEngine.UI; 

public class TurbinaComponent : MonoBehaviour
{
	public string componentName;
	public Text text;		  

	public bool isDropped; 
	

	protected virtual void Start() { 
	}

	public void ShowName() {
		text.text = componentName;
	}

	public void HideName() {
		text.enabled = false;
	}
}