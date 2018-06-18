using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classButtonActivater : MonoBehaviour {
	public GameObject[] classButtons;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void clickActivateButton(){
		classButtons [0].SetActive (true);
		classButtons [1].SetActive (true);

	}
}
