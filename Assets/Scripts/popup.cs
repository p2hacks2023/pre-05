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
    Parameter parameter;
    // Start is called before the first frame update
    void Start()
    {
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
        // goOutside();
        // popupAircon();
        // popupFrige();
        // popupUseQuestion();
    }

    public void goOutside()
    {
        var element = _uiDocument.rootVisualElement;
        var popup = new VisualElement();
        popup.AddToClassList("popup");
        popup.name = "popup";
        var newVisualElement = new VisualElement();
        newVisualElement.AddToClassList("goOutside");
        newVisualElement.name = "goOutside";

        var yesButton = new Button();
        yesButton.AddToClassList("Yes");
        yesButton.name = "goOutsideYes";
        var noButton = new Button();
        noButton.AddToClassList("No");  
        noButton.name = "goOutsideNo"; 
        popup.Add(newVisualElement);     
        newVisualElement.Add(yesButton);
        newVisualElement.Add(noButton);
        element.Add(popup);

        yesButton.clicked += clickedShopYes;
        noButton.clicked += clickedNo;
    }

    public void popupAircon()
    {
        var element = _uiDocument.rootVisualElement;
        var popup = new VisualElement();
        popup.AddToClassList("popup");
        popup.name = "popup";

        var aircon = new VisualElement();
        aircon.AddToClassList("airCon");
        var airconFrame = new VisualElement();
        airconFrame.AddToClassList("airconFrame");
        var airconTemp = new Label();
        airconTemp.AddToClassList("airconTemp");
        airconTemp.AddToClassList("japaneseFont");
        airconTemp.name = "airconTemp";
        airconTemp.text = parameter.airconditioner.ToString();
        var airconC = new Label();
        airconC.AddToClassList("airconC");
        airconC.AddToClassList("japaneseFont");
        airconC.text = "°C";
        if (parameter.airconSwitch == 0)
        {
            airconTemp.style.color = Color.clear;
        }
        else
        {
            airconTemp.style.color = Color.gray;
        }
    
        var turn = new Button();
        turn.AddToClassList("airconTurn");
        turn.name = "airconTurn";
        var up = new Button();
        up.AddToClassList("airconUp");
        up.name = "airconUp";
        var down = new Button();
        down.AddToClassList("airconDown");
        down.name = "airconDown";

        airconFrame.Add(airconTemp);
        airconFrame.Add(airconC);
        aircon.Add(airconFrame);
        aircon.Add(turn);
        aircon.Add(up);
        aircon.Add(down);
        popup.Add(aircon);
        var test = new Label();
        test.text = "test";
        element.Add(popup);

        up.clickable.clicked += airconUpFunc;
        down.clickable.clicked += airconDownFunc;
        turn.clickable.clicked += airconTurnFunc;
        element.RegisterCallback<MouseDownEvent>(e => clickedNo());
    }

    void debug()
    {
        Debug.Log("Debug");
    }
    void airconUpFunc() {
        parameter.airconditioner++;
        var element = _uiDocument.rootVisualElement.Q<Label>("airconTemp");
        element.text = parameter.airconditioner.ToString();
    }
    void airconDownFunc() {
        parameter.airconditioner--;
        var element = _uiDocument.rootVisualElement.Q<Label>("airconTemp");
        element.text = parameter.airconditioner.ToString();
    }
    void airconTurnFunc() {
        // エアコンのない内部処理とマージしてから設定
        if (parameter.airconSwitch == 0)
        {
            parameter.airconSwitch = 1;
            var airconTemp = _uiDocument.rootVisualElement.Q("airconTemp");
            airconTemp.style.color = Color.gray;
        }
        else
        {
            parameter.airconSwitch = 0;
            var airconTemp = _uiDocument.rootVisualElement.Q<Label>("airconTemp");
            airconTemp.style.color = Color.clear;
        }
    }

    void clickedShopYes()
    {
        SceneManager.LoadScene("Shop");
    }
    void clickedNo()
    {
        var element = _uiDocument.rootVisualElement.Q("popup");
        element.RemoveFromHierarchy();
    }
    void popupFrige()
    {
        var element = _uiDocument.rootVisualElement;
        var frige = new VisualElement();
        frige.AddToClassList("frige");
        frige.name = "frige";
        var items = new VisualElement();
        items.AddToClassList("items");
        var suika = new Button();
        suika.AddToClassList("suika");
        suika.AddToClassList("item");
        var ice = new Button();
        ice.AddToClassList("ice");
        ice.AddToClassList("item");
        var fish = new Button();
        fish.AddToClassList("fish");
        fish.AddToClassList("item");
        var coffee = new Button();
        coffee.AddToClassList("coffee");
        coffee.AddToClassList("item");

        items.Add(suika);
        items.Add(ice);
        items.Add(fish);
        items.Add(coffee);
        frige.Add(items);
        element.Add(frige);

        suika.clicked += popupUseQuestion;
        frige.RegisterCallback<MouseDownEvent>(e => deleteFrige());
    }
    void popupUseQuestion()
    {
        var element = _uiDocument.rootVisualElement;
        var popup = new VisualElement();
        popup.AddToClassList("popup");
        popup.name = "popup";
        var useQuestion = new VisualElement();
        useQuestion.AddToClassList("useQuestion");
        useQuestion.name = "useQuestion";
        var yesButton = new Button();
        yesButton.AddToClassList("Yes");
        yesButton.name = "Yes";
        var noButton = new Button();
        noButton.AddToClassList("No");
        noButton.name = "No";

        popup.Add(useQuestion);
        useQuestion.Add(yesButton);
        useQuestion.Add(noButton);
        element.Add(popup);

        yesButton.clicked += deleteFrige;
        yesButton.clicked += clickedNo;
        noButton.clicked += clickedNo;
    }
    void deleteFrige()
    {
        var element = _uiDocument.rootVisualElement.Q("frige");
        element.RemoveFromHierarchy();
    }
}
