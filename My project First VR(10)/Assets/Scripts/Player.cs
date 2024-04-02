using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public static Player st;

	[HideInInspector] public Transform ts;

	public void Awake() {
		st = this;
		ts = transform;
	}
}
