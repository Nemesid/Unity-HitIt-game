using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public GameObject gameoverPannel;
	bool gameend = false;
	static public int CoinScore = 0;
	public Text Coin;
	public Text highCoin;
	public Transform Ball;
	public Movement move;
	public AndroidMovement And;

	void Start()
	{
		highCoin.text = PlayerPrefs.GetInt("HighCoin", 0).ToString();
	}
	public void EndGame()
	{
		if (gameend == false)
		{
			gameend = true;

			Invoke ("GameOver", 1.5f);
		}
	}

	void GameOver()
	{
		gameoverPannel.SetActive (true);

	}
	public void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		BallCollision.deathcount = 1;
		checkpoint.ischecked = false;
	}

	void Update()
	{
		
		Coin.text = CoinScore.ToString("0");
		PlayerPrefs.SetInt ("HighCoin", (int)CoinScore);
		highCoin.text = CoinScore.ToString ();

	}



	}




