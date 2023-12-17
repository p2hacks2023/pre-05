using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class TimeElapsed : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;
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
        // Time.sincelevelLoad += Time.deltaTime;
        // 昼の時間と夜の時間はそれぞれ96秒 １秒で5分が経過
        if (dayNum == 0) {
            if (parameter.time > 96f) {
                dayNum = 1;
                day.enabled = false;
                night.enabled = true;
                deskLight.enabled = true;
                // camera.backgroundColor = new Color(0.6132076f, 0.2983172f, 0, 1);/
                camera.backgroundColor = new Color(0.03918803f, 0, 0.2264151f, 1);
                if (Parameter.fireworks == 0)
                {
                    Parameter.fireworks = 1;         
                    SceneManager.LoadScene("FireworksOpening");       
                }
                else if (Parameter.fireworks == 1)
                {
                    createAchive();
                }
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
    void createAchive()
    {
        var element = _uiDocument.rootVisualElement;
        var achive = new VisualElement();
        achive.AddToClassList("achievements");
        var achiveFrame = new VisualElement();
        achiveFrame.AddToClassList("achievementsFrame");
        var achiveText = new Label();
        achiveText.text = "Get Achivements";

        achive.Add(achiveFrame);
        achiveFrame.Add(achiveText);
        element.Add(achive);
        achive.RegisterCallback<MouseDownEvent>(e => changeScene());

    }
    void changeScene()
    {
        SceneManager.LoadScene("Still");
    }
}
 
