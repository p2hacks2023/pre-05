using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_load : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;
    Label hour;
    Label minutes;
    Label templature;
    Parameter parameter;

    // Start is called before the first frame update
    void Start()
    {
        hour = _uiDocument.rootVisualElement.Q<Label>("hour");
        minutes = _uiDocument.rootVisualElement.Q<Label>("minutes");
        templature = _uiDocument.rootVisualElement.Q<Label>("templature");
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
    }

    // Update is called once per frame
    void Update()
    {
        hour.text = Mathf.FloorToInt(parameter.time*5/60+10).ToString("0");
        minutes.text = (parameter.time*5%60).ToString("00");
        templature.text = parameter.temperature.ToString("0");
    }
}
