using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    [SerializeField]
    // 昼間の空のマテリアル
    public Material sky;
    // 夜の空のマテリアル
    public Material night;
    // スカイボックスを格納する変数
    private Material skyboxMaterial;
    // 経過時間を格納する変数
    private float time;
    Parameter parameter;
    // 夜になったかどうかを判定する変数
    private bool tf = false;
    void Start()
    {
        // スカイボックスを設定
        RenderSettings.skybox = Instantiate(sky);
        skyboxMaterial = RenderSettings.skybox;
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
    }

    // Update is called once per frame
    void Update()
    {
        // time += Time.deltaTime;
        // 時間経過で空を暗くしたり、夜になったりする
        // Time.sincelevelLoad += Time.deltaTime;
        if (parameter.time < 10.0f) {
            var c = skyboxMaterial.GetColor("_Tint");
            c.r -= 0.0002f;
            c.g -= 0.0002f;
            c.b -= 0.0002f;
            skyboxMaterial.SetColor("_Tint", c);
        }
        else if (parameter.time > 10.0f && !tf) {
            tf = true;
            RenderSettings.skybox = Instantiate(night);
        }
	}
}
 
