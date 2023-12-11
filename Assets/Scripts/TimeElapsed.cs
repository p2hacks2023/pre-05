using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 0.5f;
    public Material sky;
    public Material night;
    private Material skyboxMaterial;
    private float time = 0;
    void Start()
    {
        RenderSettings.skybox = Instantiate(sky);
        skyboxMaterial = RenderSettings.skybox;
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if (time < 2500) {
            var c = skyboxMaterial.GetColor("_Tint");
            c.r -= 0.0002f;
            c.g -= 0.0002f;
            c.b -= 0.0002f;
            skyboxMaterial.SetColor("_Tint", c);
        }
        else if (time == 2500) {
            RenderSettings.skybox = Instantiate(night);
        }
	}
}
 