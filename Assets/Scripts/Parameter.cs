using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameter : MonoBehaviour
{
    // ゲーム内時間
    public float time = 0.0f;
    // 部屋の気温
    public float temperature = 0.0f;
    // 天気
    public int weather = 0;
    // ひんやり度
    public int cool = 0;
    // エアコンの温度
    public int airconditioner = 0;
    // 猫の名前
    public string catName = "概念ﾈｺ";
    // 所持金
    public int money = 0;

    //以下ゲーム内購入アイテム


    //各アイテムの表示名
    public string ITEMNAME0 = "アイスクリーム";
    public string ITEMNAME1 = "スイカ";
    public string ITEMNAME2 = "ホットコーヒー";
    public string ITEMNAME3 = "さかな";


    //アイスクリームの所持数
    public int icecream = 0;
    //スイカの所持数
    public int watermelon = 0;
    //ホットコーヒーの所持数
    public int coffe = 0;
    //魚の所持数
    public int fish = 0;

    //アイスクリームの価格
    public int ICECREAMPRICE = 100;
    //スイカの価格
    public int WATERMELONPRICE = 200;
    //ホットコーヒーの価格
    public int COFFEPRICE = 120;
    //魚の価格
    public int FISHPRICE = 80;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }
}
