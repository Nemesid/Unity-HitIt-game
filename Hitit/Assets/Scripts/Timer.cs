using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	float time;
	public Text TimeText;
	public Text highminute;
	public Text highsecond;
	public GameObject Gameover;



	void Start()
	{
		highminute.text = PlayerPrefs.GetInt("HighMinute", 0).ToString();
		highsecond.text = PlayerPrefs.GetInt("HighSecond", 0).ToString();

	}
	void FixedUpdate()
	{
		
			time += Time.deltaTime;
		var minutes = Mathf.Floor(time / 60);
		var seconds = Mathf.Floor(time % 60);

		TimeText.text = string.Format("{0:00} : {1:00}",minutes,seconds);
		if (Gameover.activeSelf == true) {
			if (minutes > PlayerPrefs.GetInt ("HighMinute", 0)) {
				PlayerPrefs.SetInt ("HighMinute", (int)minutes);
				highminute.text = minutes.ToString ();
			}
			if (seconds> PlayerPrefs.GetInt ("HighSecond", 0)) {
			
				PlayerPrefs.SetInt ("HighSecond", (int)seconds);
				highsecond.text = seconds.ToString ();
			
			}



			
	}
	}
	public void reset()
	{
		PlayerPrefs.DeleteAll();
		highminute.text = "0";
		highsecond.text = "0";
	}
}