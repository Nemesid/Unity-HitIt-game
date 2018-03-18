using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject pausemenuui;
	public GameObject Howtoplay;
	public GameObject HighScore;
	public GameObject Gameinfo;
	static public bool gameispaused = false;

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if(gameispaused)
			{
				Resume();
			}
			else{
				Pause();
			}
		}

	}
	public void Resume()
	{
		pausemenuui.SetActive(false);
		Time.timeScale = 1f;
		gameispaused = false;
		Gameinfo.SetActive (true);
	}
	public void Pause()
	{
		Gameinfo.SetActive (false);
		pausemenuui.SetActive(true);
		Time.timeScale = 0f;
		gameispaused = true;
	}
	public void LoadMenu()
	{
		pausemenuui.SetActive(false);
		Time.timeScale = 1f;
		gameispaused = false;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
	}
	public void QuitMenu()
	{
		Application.Quit();
	}
	public void HowToPlay()
	{
		Howtoplay.SetActive (true);
		Gameinfo.SetActive (false);
	}
	public void HowToResume()
	{
		Howtoplay.SetActive (false);
	}
	public void HighScoreOpen()
	{
		HighScore.SetActive (true);
		Gameinfo.SetActive (false);
	}
	public void HighScoreClose()
	{
		HighScore.SetActive (false);
	}
}
