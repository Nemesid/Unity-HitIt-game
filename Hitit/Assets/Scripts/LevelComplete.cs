using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public void LoadNxtLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}