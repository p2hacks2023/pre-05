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
    public Text haveMoney;
    //public Text itemBuy2;
    //public Text itemBuy3;



    // 表示する変数
    //Parameter parameter;
 
    // Use this for initialization
    void Start () {

    }
     
    // Update is called once per frame
    void Update () {

        itemPrice0.text = string.Format("{0} 円", Parameter.ICECREAMPRICE);
        itemPrice1.text = string.Format("{0} 円", Parameter.WATERMELONPRICE);
        itemPrice2.text = string.Format("{0} 円", Parameter.COFFEPRICE);
        itemPrice3.text = string.Format("{0} 円", Parameter.FISHPRICE);

        haveMoney.text = string.Format("所持金：{0} 円", Parameter.money);

        if(Parameter.shopItemSelect==0)
        itemBuy0.text = string.Format("{0} を {1} 円で購入しますか？\n所持数:{2}",Parameter.ITEMNAME0, Parameter.ICECREAMPRICE,Parameter.icecream);
        else if(Parameter.shopItemSelect==1)
        itemBuy0.text = string.Format("{0} を {1} 円で購入しますか？\n所持数:{2}",Parameter.ITEMNAME1, Parameter.WATERMELONPRICE,Parameter.watermelon);
        else if(Parameter.shopItemSelect==2)
        itemBuy0.text = string.Format("{0} を {1} 円で購入しますか？\n所持数:{2}",Parameter.ITEMNAME2, Parameter.COFFEPRICE,Parameter.coffe);
        else if(Parameter.shopItemSelect==3)
        itemBuy0.text = string.Format("{0} を {1} 円で購入しますか？\n所持数:{2}",Parameter.ITEMNAME3, Parameter.FISHPRICE,Parameter.fish);
    }
}