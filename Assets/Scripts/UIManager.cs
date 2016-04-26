using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	//Reloads the Level
	public void Play(){
		Application.LoadLevel("scene1");
	}
}