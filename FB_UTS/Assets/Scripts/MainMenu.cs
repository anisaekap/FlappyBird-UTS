using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public AudioSource buttonSound;
    public void LevelGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void QuitGame(){
		Application.Quit();
	}
	
	void OnMouseDown(){
		buttonSound.PlayOneShot(buttonSound.clip);
	}
	void OnMouseUp(){
		buttonSound.PlayOneShot(buttonSound.clip);
	}
	
}
