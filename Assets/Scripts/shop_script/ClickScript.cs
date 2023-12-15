using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ClickScript : MonoBehaviour
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

  public void ButtonClick0()
  {
    parameter.shopItemSelect=0;
  }
  public void ButtonClick1()
  {
    parameter.shopItemSelect=1;
  }
  public void ButtonClick2()
  {
    parameter.shopItemSelect=2;
  }
  public void ButtonClick3()
  {
    parameter.shopItemSelect=3;
  }

  public void ButtonClickYes()
  {
    if(parameter.shopItemSelect==0)parameter.icecream += 1 ;
  
    else if(parameter.shopItemSelect==1)parameter.watermelon += 1 ;
  
    else if(parameter.shopItemSelect==2)parameter.coffe += 1 ;
 
    else if(parameter.shopItemSelect==3)parameter.fish += 1 ;
  }

}