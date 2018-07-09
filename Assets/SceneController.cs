using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;


public class SceneController : MonoBehaviour {

    public GameObject ARCamera;

    void Awake(){
		
		/*ARCamera = GameObject.Find("ARCamera");

		ARCamera.GetComponent<VuforiaBehaviour>().enabled = false;*/

	}

	void Start(){


	}

  	public void loadLevel(){

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		print("NEW SCENE LOADED!");

	}
}