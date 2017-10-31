using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Restart : MonoBehaviour {

	void Awake() {
		Pathmaker.globalCounter = Random.Range (200, 500);
	}

	public string Todoroki;
	public void restart(){
		SceneManager.LoadScene (Todoroki); 

	}
	void Update (){
		if (Input.GetKeyDown (KeyCode.R)){
			SceneManager.LoadScene (Todoroki); 
		}
	}

}
