using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour {

	public void StartG()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
