using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPreviousCar : MonoBehaviour {
	public GameObject[] cars;
	private int currenti;
	private int previousi;
	// Use this for initialization
	void Start () {
		currenti = 0;
		cars [currenti].SetActive (true);
		//Instantiate (cars[currenti],new Vector3(0,0,0),Quaternion.identity);

	}
	
	// Update is called once per frame


	public void NextCar(){
		cars [currenti].SetActive (false);
		if (currenti == cars.Length-1)
			currenti = 0;
		else
			currenti++;
		cars [currenti].SetActive (true);

	}

	public void PreviousCar(){
		cars [currenti].SetActive (false);
		if (currenti == 0) {
			currenti = cars.Length - 1;
		} else {
			currenti--;
		}
		cars [currenti].SetActive (true);


	}
}
