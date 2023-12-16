using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class popup : MonoBehaviour
{
    [SerializeField] private UIDocument _uiDocument;
    private Button goOusYes;
    private Button goOusNo;
    // Start is called before the first frame update
    void Start()
    {
        // goOutside();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void goOutside()
    {
        var element = _uiDocument.rootVisualElement.Q("popup");
        var newVisualElement = new VisualElement();
        newVisualElement.AddToClassList("goOutside");
        newVisualElement.name = "goOutside";

        var yesButton = new Button();
        yesButton.AddToClassList("Yes");
        yesButton.name = "goOutsideYes";
        var noButton = new Button();
        noButton.AddToClassList("No");  
        noButton.name = "goOutsideNo";      
        newVisualElement.Add(yesButton);
        newVisualElement.Add(noButton);
        element.Add(newVisualElement);

        yesButton.clicked += clickedYes;
        noButton.clicked += clickedNo;
    }

    void clickedYes()
    {
        SceneManager.LoadScene("Title");
    }
    void clickedNo()
    {
        var element = _uiDocument.rootVisualElement.Q("goOutside");
        element.RemoveFromHierarchy();
    }
}
