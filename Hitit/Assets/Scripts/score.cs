using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public double pos, scr;
	public Transform Ball;
	public Text scoretext;
	public Text highScore;

	public GameObject Gameover;
	public GameObject Gameinfo;
	void Start()
	{
		highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	}
	void Update () {
		pos = Ball.position.z;
		scr = pos + 4999.24;
		scoretext.text = scr.ToString ("0");
		if (Gameover.activeSelf == true) {
			Gameinfo.SetActive (false);
			if (scr > PlayerPrefs.GetInt ("HighScore", 0)) {
				PlayerPrefs.SetInt ("HighScore", (int)scr);
				highScore.text = 1+ scr.ToString ();
			}

		}
		if (Gameover.activeSelf == false) {
			Gameinfo.SetActive (true);
		}
	}
	public void reset()
	{
		PlayerPrefs.DeleteAll();
		highScore.text = "0";
	}
}
