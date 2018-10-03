using System;
using System.Collections;
using UnityEngine;

public class DataDisplayer : MonoBehaviour
{
  public GameObject Text;
  void Display(Vector3 vector)
  {

    GameObject text = Instantiate(Text, vector, Quaternion.identity);
  }
}
