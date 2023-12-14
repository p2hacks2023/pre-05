using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTextCntrol_Shop : MonoBehaviour
{
   // UI Text指定用

    public Text itemPrice0;
    public Text itemPrice1;
    public Text itemPrice2;
    public Text itemPrice3;

    public Text itemBuy0;
    public Text itemBuy1;
    public Text itemBuy2;
    public Text itemBuy3;



    // 表示する変数
    Parameter parameter;
 
    // Use this for initialization
    void Start () {
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();

    }
     
    // Update is called once per frame
    void Update () {

        itemPrice0.text = string.Format("{0} 円", parameter.ICECREAMPRICE);
        itemPrice1.text = string.Format("{0} 円", parameter.WATERMELONPRICE);
        itemPrice2.text = string.Format("{0} 円", parameter.COFFEPRICE);
        itemPrice3.text = string.Format("{0} 円", parameter.FISHPRICE);
        itemBuy0.text = string.Format("{0} を {1} 円で購入しますか？\n所持数:{2}",parameter.ITEMNAME0, parameter.ICECREAMPRICE,parameter.icecream);
        itemBuy1.text = string.Format("{0} を {1} 円で購入しますか？\n所持数:{2}",parameter.ITEMNAME1, parameter.WATERMELONPRICE,parameter.watermelon);
        itemBuy2.text = string.Format("{0} を {1} 円で購入しますか？\n所持数:{2}",parameter.ITEMNAME2, parameter.COFFEPRICE,parameter.coffe);
        itemBuy3.text = string.Format("{0} を {1} 円で購入しますか？\n所持数:{2}",parameter.ITEMNAME3, parameter.FISHPRICE,parameter.fish);
    }
}