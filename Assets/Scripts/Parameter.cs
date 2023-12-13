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
