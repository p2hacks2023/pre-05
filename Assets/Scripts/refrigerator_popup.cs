using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class refrigerator_popup : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;

    // Start is called before the first frame update
    void Start()
    {
        var element = _uiDocument.rootVisualElement.Q("popup");
        // var newVisualElement = new Button();
        // newVisualElement.name = "AddButton";
        // newVisualElement.AddToClassList("sample-button");
        // newVisualElement.text = "Add";
        // element.Add(newVisualElement);


        
        var newVisualElement2 = new VisualElement();
        var label = new Label();
        label.text = "Hello World!";
        newVisualElement2.Add(label);
        element.Add(newVisualElement2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
