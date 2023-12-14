using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{

	public void startGame()
	{
		SceneManager.LoadScene("Opening");
	}
}