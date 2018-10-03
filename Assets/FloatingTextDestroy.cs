using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextDestroy : MonoBehaviour {
	public float time = 3f;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, time);
	}
}
