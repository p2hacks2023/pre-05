using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ClickScriptCoffe : MonoBehaviour
{

    Parameter parameter;

  // Use this for initialization
  void Start()
  {
    parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void ButtonClick()
  {
    parameter.coffe += 1 ;
  }

}