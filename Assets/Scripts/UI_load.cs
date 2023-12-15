using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_load : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;
    Time time;
    // Start is called before the first frame update
    void Start()
    {
        time = _uiDocument.rootVisualElement.Q("time");
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "Hello World!";
    }
}
