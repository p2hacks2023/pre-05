using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Parameter : MonoBehaviour
{   
    //mainsceneの読み込み回数
    public static int sceneLoad = 0;

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
    public static int money = 1000;



    //以下ゲーム内購入アイテム----------


    //各アイテムの表示名
    public static string ITEMNAME0 = "アイスクリーム";
    public static string ITEMNAME1 = "スイカ";
    public static string ITEMNAME2 = "ホットコーヒー";
    public static string ITEMNAME3 = "さかな";

    //アイスクリームの所持数
    public static int icecream = 0;
    //スイカの所持数
    public static int watermelon = 0;
    //ホットコーヒーの所持数
    public static int coffe = 0;
    //魚の所持数
    public static int fish = 0;

    //アイスクリームの価格
    public static int ICECREAMPRICE = 100;
    //スイカの価格
    public static int WATERMELONPRICE = 200;
    //ホットコーヒーの価格
    public static int COFFEPRICE = 120;
    //魚の価格
    public static int FISHPRICE = 80;


    //以下shop動作用変数------

    //ショップ内でアイテムの画像を押したときにどのアイテムか判別する変数
    //0~3の値でクリックされたボタンを別スクリプトにて検知。
    public static int shopItemSelect = 0;
    



    // Start is called before the first frame update
    void Start()
    {   
        sceneLoad += 1;

        if(sceneLoad!=1){
            time = PlayerPrefs.GetFloat("timeSaved"); 
            temperature = PlayerPrefs.GetFloat("temperatureSaved");
            weather = PlayerPrefs.GetInt("weatherSaved");
            cool = PlayerPrefs.GetInt("coolSaved");
            airconditioner = PlayerPrefs.GetInt("airconditionerSaved");   
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // 時間パラメータとして扱いたい数値の保存
        PlayerPrefs.SetFloat("timeSaved", time);
        PlayerPrefs.SetFloat("temperatureSaved", temperature);
        PlayerPrefs.SetInt("weatherSaved", weather);
        PlayerPrefs.SetInt("coolSaved", cool);
        PlayerPrefs.SetInt("airconditionerSaved", airconditioner);

    }
}
