using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ClickScript : MonoBehaviour
{

    //Parameter parameter;

  // Use this for initialization
  void Start()
  {
    //parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void ButtonClick0()
  {
    Parameter.shopItemSelect=0;
  }
  public void ButtonClick1()
  {
    Parameter.shopItemSelect=1;
  }
  public void ButtonClick2()
  {
    Parameter.shopItemSelect=2;
  }
  public void ButtonClick3()
  {
    Parameter.shopItemSelect=3;
  }

  public void ButtonClickYes()
  {
    if(Parameter.shopItemSelect==0)Parameter.icecream += 1 ;
  
    else if(Parameter.shopItemSelect==1)Parameter.watermelon += 1 ;
  
    else if(Parameter.shopItemSelect==2)Parameter.coffe += 1 ;
 
    else if(Parameter.shopItemSelect==3)Parameter.fish += 1 ;
  }

}