﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	public AudioSource buttonSound;
	public string namaScene;
    public void PindahLevel(){
		Scene sceneIni = SceneManager.GetActiveScene();
		
		if(sceneIni.name != namaScene){
			SceneManager.LoadScene(namaScene);
		}
	}
	
	void OnMouseDown(){
		buttonSound.PlayOneShot(buttonSound.clip);
	}
	void OnMouseUp(){
		buttonSound.PlayOneShot(buttonSound.clip);
	}
}
