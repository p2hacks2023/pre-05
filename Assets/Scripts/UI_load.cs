using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_load : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;
    Label time;
    Label templature;
    Parameter parameter;

    // Start is called before the first frame update
    void Start()
    {
        time = _uiDocument.rootVisualElement.Q<Label>("time");
        templature = _uiDocument.rootVisualElement.Q<Label>("templature");
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "経過時間：" + parameter.time.ToString("0") + "秒";
        templature.text = parameter.temperature.ToString();
    }
}
