using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CamCtrl : MonoBehaviour
{
    private Camera cam;
    private Vector3 startPos;
    private Vector3 startAngle;
    private float camX, camY, camZ; // cameraの座標
    private float speed;
 
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        camX = 0.0f;
        camY = 1.0f;
        camZ = -10.0f;
    }
 
    // Update is called once per frame
    void Update()
    {
        if (cam == null)
        {
            return;
        }
 
        float sensitiveMove = 0.8f;
        float sensitiveRotate = -2.0f;
        float sensitiveZoom = 10.0f;
        float dontMove = 0.0f;
 
        if (Input.GetMouseButton(0))
        {
            // move camera
            float moveX = Input.GetAxis("Mouse X") * sensitiveMove;
            float moveY = Input.GetAxis("Mouse Y") * sensitiveMove;
           // cam.transform.localPosition -= new Vector3(moveX, moveY, 0.0f);
              cam.transform.position += cam.transform.forward * moveX;
        }
        else if (Input.GetMouseButton(1))
        {
            // rotate camera
            float rotateX = Input.GetAxis("Mouse X") * sensitiveRotate;
            float rotateY = Input.GetAxis("Mouse Y") * sensitiveRotate;
            cam.transform.eulerAngles += new Vector3(rotateY, rotateX, 0.0f);
        }
        
        if (Input.GetKey(KeyCode.LeftControl)){
        cam.transform.localPosition = new Vector3(camX, camY, camZ);
        cam.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        }
 
        // zoom camera
        float moveZ = Input.GetAxis("Mouse ScrollWheel") * sensitiveZoom;
        cam.transform.position += cam.transform.forward * moveZ;
    }
}