using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

<<<<<<< HEAD
public class SceneButton : MonoBehaviour
=======
public class GameSystem : MonoBehaviour
>>>>>>> ec4c3cb079abb1ba61b6c67371ead276854c9578
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
<<<<<<< HEAD
=======
<<<<<<<< HEAD:Assets/Scripts/Title_Button.cs
========
	
>>>>>>>> ec4c3cb079abb1ba61b6c67371ead276854c9578:Assets/Scripts/SceneButton.cs
>>>>>>> ec4c3cb079abb1ba61b6c67371ead276854c9578
	}
}