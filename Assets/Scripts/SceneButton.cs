using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

    




public class SceneButton : MonoBehaviour
{
	Parameter parameter;

	
	void Start()
    {
       //parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();

    }

	public void startGame()
	{
		SceneManager.LoadScene("Opening");
	}
	public void moveMain()
	{
		SceneManager.LoadScene("Main Scene");
	}
	public void moveShop()
	{
		SceneManager.LoadScene("Shop");

	}
}
