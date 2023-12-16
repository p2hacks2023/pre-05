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
    void useSuika()
    {
        var element = _uiDocument.rootVisualElement;
        var popup2 = new VisualElement();
        popup2.AddToClassList("popup2");
        popup2.name = "popup2";

        var useQyestion = new VisualElement();
        useQyestion.AddToClassList("useQuestion");
        useQyestion.name = "useQuestion";

        var yes = new Button();
        yes.AddToClassList("Yes");
        yes.name = "Yes";
        var no = new Button();
        no.AddToClassList("No");
        no.name = "No";

        useQyestion.Add(yes);
        useQyestion.Add(no);
        popup2.Add(useQyestion);
        element.Add(popup2);

        yes.clicked += clickedNo;
        yes.clicked += deletePopup2;
        no.clicked += deletePopup2;
    }
    void deletePopup2()
    {
        var element = _uiDocument.rootVisualElement.Q("popup2");
        element.RemoveFromHierarchy();
    }
    public void popupFrige()
    {
        var element = _uiDocument.rootVisualElement;
        var popup = new VisualElement();
        popup.AddToClassList("popup");
        popup.name = "popup";

        var frige = new VisualElement();
        frige.AddToClassList("frige");
        frige.name = "frige";
        var frigeItemFrame = new VisualElement();
        frigeItemFrame.AddToClassList("frigeItemFrame");

        var suika = new Button();
        suika.AddToClassList("suika");
        suika.AddToClassList("item");
        suika.name = "suika";
        var ice = new Button();
        ice.AddToClassList("ice");
        ice.AddToClassList("item");
        ice.name = "ice";
        var coffe = new Button();
        coffe.AddToClassList("coffe");
        coffe.AddToClassList("item");
        coffe.name = "coffe";
        var fish = new Button();
        fish.AddToClassList("fish");
        fish.AddToClassList("item");
        fish.name = "fish";

        frigeItemFrame.Add(suika);
        frigeItemFrame.Add(ice);
        frigeItemFrame.Add(coffe);
        frigeItemFrame.Add(fish);
        frige.Add(frigeItemFrame);
        popup.Add(frige);
        element.Add(popup);
        suika.clicked += useSuika;
    }
    void debug()
    {
        Debug.Log("Debug");
    }
}
