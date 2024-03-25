using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Optionschoos : TurbinaComponent
{
	public GameObject prefab;

	public void FirstRoom() {
		prefab.transform.position = new Vector3(3, 1, 4);
	}
	public void SecondRoom() {
		prefab.transform.position = new Vector3(3, 1, 16);
	}
	public void ThirdRoom() {
		prefab.transform.position = new Vector3(3, 1, 28);
	}
	public void BackHome() {
		prefab.transform.position = new Vector3(-1, 16, 18);
	}
}