using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {
	public GameObject FloatingText;
	public void Coll()
	{
		string text1 = name;
		FloatingText.GetComponent<TextMesh>().text = name;
		Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
		
	}
}
