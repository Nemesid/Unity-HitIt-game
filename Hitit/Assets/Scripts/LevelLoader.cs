using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour {

	public GameObject Loader;
	public Slider slider;
	public Text ProgressText;
	public void LoadLevel (int sceneIndex)
	{
		StartCoroutine(LoadAsynchronously(sceneIndex));
	}
	IEnumerator LoadAsynchronously (int sceneIndex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);
		Loader.SetActive (true);
		while (!operation.isDone) {
			float progress = Mathf.Clamp01(operation.progress / .9f);
			ProgressText.text = Mathf.RoundToInt(progress) * 100f + "%";
			slider.value = Mathf.RoundToInt(progress);
			yield return null;
		}
	}
	}
