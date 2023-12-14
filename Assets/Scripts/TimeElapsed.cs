using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    [SerializeField]
    // 経過時間を格納する変数
    private float time;
    Parameter parameter;
    // 夜になったかどうかを判定する変数
    private bool tf = false;
    private int day = 0;
    public Camera camera;
    
    
    void Start()
    {
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
    }

    // Update is called once per frame
    void Update()
    {
        // time += Time.deltaTime;
        // 時間経過で空を暗くしたり、夜になったりする
        // Time.sincelevelLoad += Time.deltaTime;
        if (day == 0) {
            if (parameter.time > 5f) {
                day = 1;
            }
        }
	}
}
 
