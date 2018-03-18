using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadHighScore : MonoBehaviour {
	public Text highScore;
	public Text highminute;
	public Text highsecond;
	public Text highCoin;
	// Use this for initialization
	void Start () {
		highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
		highminute.text = PlayerPrefs.GetInt("HighMinute", 0).ToString();
		highsecond.text = PlayerPrefs.GetInt("HighSecond", 0).ToString();
		highCoin.text = PlayerPrefs.GetInt ("HighCoin", 0).ToString ();
	}

	public void reset()
	{
		PlayerPrefs.DeleteAll();
		highScore.text = "0";
		highminute.text = "0";
		highsecond.text = "0";
		highCoin.text = "0";
	}
}
