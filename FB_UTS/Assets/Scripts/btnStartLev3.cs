using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnStartLev3 : MonoBehaviour
{
	public AudioSource buttonSound;
	float x,y;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.localScale.x;
		y = transform.localScale.y;
    }
	
	void OnMouseDown(){
		buttonSound.PlayOneShot(buttonSound.clip);
		transform.localScale = new Vector2(x/1.2f,y/1.2f);
	}
	
	void OnMouseUp(){
		buttonSound.PlayOneShot(buttonSound.clip);
		transform.localScale = new Vector2 (x,y);
		Time.timeScale = 1;
		Application.LoadLevel ("Level 3");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
