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
    private int dayNum = 0;
    public Camera camera;
    public Light day;
    public Light night;
    public Light deskLight;
    
    // 0.5235849 0.8560204 1 1
    void Start()
    {
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
        day.enabled = true;
        night.enabled = false;
        deskLight.enabled = false;
        camera.backgroundColor = new Color(0.5235849f, 0.8560204f, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // time += Time.deltaTime;
        // 時間経過で空を暗くしたり、夜になったりする
        // Time.sincelevelLoad += Time.deltaTime;
        if (dayNum == 0) {
            if (parameter.time > 60f) {
                dayNum = 1;
                day.enabled = false;
                night.enabled = true;
                deskLight.enabled = true;
                // camera.backgroundColor = new Color(0.6132076f, 0.2983172f, 0, 1);/
                camera.backgroundColor = new Color(0.03918803f, 0, 0.2264151f, 1);
            }
        
        }
        if (dayNum == 1) {
            if (parameter.time > 120f) {
                dayNum = 2;
                night.enabled = false;
                camera.backgroundColor = new Color(0.03918803f, 0, 0.2264151f, 1);
            }
        }
	}
}
 
