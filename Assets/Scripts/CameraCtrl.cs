using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CamCtrl : MonoBehaviour
{
    private Camera cam;
    private float CAMX, CAMY, CAMZ, CAMRX, CAMRY, CAMRZ; // cameraの座標
 
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();//カメラを使用するための設定。（取得）
        CAMX = 3.0f;//カメラの初期位置
        CAMY = 3.30f;
        CAMZ = -5.0f;

        CAMRX = 20.0f;//カメラの初期位置(角度)
        CAMRY = -27.0f;
        CAMRZ = 0.0f;
    }
 
    // Update is called once per frame
    void Update()
    {
        if (cam == null)
        {
            return;
        }
 
        float SENSITIVEMOVE = 0.8f;//カメラ動き感度
        float SENSITIVERORATE = -2.0f;//カメラ回転感度。-を消すと操作が反転
        float SENSITIVEZOOM = 10.0f;//ズーム感度
    
 
        if (Input.GetMouseButton(0))//カメラをマウスの左クリックで動かす。現在は無効化
        {
            // move camera
            float moveX = Input.GetAxis("Mouse X") * SENSITIVEMOVE;
            float moveY = Input.GetAxis("Mouse Y") * SENSITIVEMOVE;
           // cam.transform.localPosition -= new Vector3(moveX, moveY, 0.0f);
        }
        else if (Input.GetMouseButton(1))//カメラの回転
        {
            // rotate camera
            float rotateX = Input.GetAxis("Mouse X") * SENSITIVERORATE;
            float rotateY = Input.GetAxis("Mouse Y") * SENSITIVERORATE;
            cam.transform.eulerAngles += new Vector3(rotateY, -rotateX, 0.0f);
        }
        
        
        if (Input.GetKey(KeyCode.LeftControl)){//カメラのリセット
        cam.transform.localPosition = new Vector3(CAMX, CAMY, CAMZ);
        cam.transform.eulerAngles = new Vector3(CAMRX, CAMRY, CAMRZ);
        }
        
        if (Input.GetKeyDown(KeyCode.W)){//カメラのWASD移動
        cam.transform.position += cam.transform.forward * 1;
        }
        if (Input.GetKeyDown(KeyCode.S)){
        cam.transform.position += cam.transform.forward * -1;
        }
        if (Input.GetKeyDown(KeyCode.A)){
        cam.transform.position += cam.transform.right * -1;
        }
        if (Input.GetKeyDown(KeyCode.D)){
        cam.transform.position += cam.transform.right * 1;
        }
        if (Input.GetKeyDown(KeyCode.E)){
        cam.transform.position += cam.transform.up * 1;
        }
        if (Input.GetKeyDown(KeyCode.Q)){
        cam.transform.position += cam.transform.up * -1;
        }
   
 
        //カメラのズーム
        float moveZ = Input.GetAxis("Mouse ScrollWheel") * SENSITIVERORATE;
        cam.transform.position += cam.transform.forward * moveZ;
    }
}