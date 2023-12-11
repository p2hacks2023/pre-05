using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    [SerializeField]
    public Material sky;
    public Material night;
    private Material skyboxMaterial;
    private float time = 0;
    private bool tf = false;
    void Start()
    {
        RenderSettings.skybox = Instantiate(sky);
        skyboxMaterial = RenderSettings.skybox;
    }

    // Update is called once per frame
    void Update()
    {
        // Time.sincelevelLoad += Time.deltaTime;
        time += Time.deltaTime;
        if (time < 10.0f) {
            var c = skyboxMaterial.GetColor("_Tint");
            c.r -= 0.0002f;
            c.g -= 0.0002f;
            c.b -= 0.0002f;
            skyboxMaterial.SetColor("_Tint", c);
        }
        else if (time > 10.0f && !tf) {
            tf = true;
            RenderSettings.skybox = Instantiate(night);
        }
	}
}
 