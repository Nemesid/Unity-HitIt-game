using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.IO;
public class Settingsmenu : MonoBehaviour {
	public AudioMixer am;
	public GameObject HowToPlay;
	public GameObject highScore;
	public SettingsManager setm;

	public void SetVolume(float Volume)
	{
		//Volume = PlayerPrefs.GetFloat ("SaveVolume", 0f);
		am.SetFloat("Volume", Volume);
		//PlayerPrefs.SetFloat ("SaveVolume", Volume);
	}
	public void howtoplay()
	{
		HowToPlay.SetActive (true);
	}
	public void howtoback()
	{
		HowToPlay.SetActive (false);
	}
	public void highscoremenu()
	{
		highScore.SetActive (true);
	}
	public void highscoreclose()
	{
		highScore.SetActive (false);		
	}
	public void SetQuality(int qualityindex)
	{

		QualitySettings.SetQualityLevel (qualityindex);
	}
}
