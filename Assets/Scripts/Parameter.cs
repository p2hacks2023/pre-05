using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

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

    //アイスクリームの所持数
    public int icecream = 0;
    //スイカの所持数
    public int watermelon = 0;
    //ホットコーヒーの所持数
    public int coffe = 0;
    [SerializeField] private UIDocument _uiDocument;
    VisualElement element;


    // Start is called before the first frame update
    void Start()
    {
        element = _uiDocument.rootVisualElement.Q("meterFrontground");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // 360pxを基準にしている
        element.style.height = 360-(int)(cool*3.6);
    }
}
