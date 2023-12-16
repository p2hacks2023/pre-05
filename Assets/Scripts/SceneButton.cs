using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour


{

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
	public void moveFireworks()
	{
		SceneManager.LoadScene("Fireworks");

	}
}