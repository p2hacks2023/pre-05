using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTextCntrol : MonoBehaviour
{
   // UI Text指定用
    public Text TextFrame;
    // 表示する変数
    Parameter parameter;
 
    // Use this for initialization
    void Start () {
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();

    }
     
    // Update is called once per frame
    void Update () {
        TextFrame.text = string.Format("icecream{0}", parameter.icecream);
    }
}