using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	string message = "Help Me!";

	// Use this for initialization
	void Start () {
		print("Hello World!");

	}
	
	// Update is called once per frame
	void Update () {
		print(message);
	}
}
