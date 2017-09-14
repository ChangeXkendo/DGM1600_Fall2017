using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour {

public string stopLight = "Red";

void Start(){
	Main();
}
void Main(){
	if(stopLight == "Red"){
	print("Stop! The light is red!");
	}
	else if (stopLight == "Yellow"){
		print("Slow Down!");
	}
	else if (stopLight == "Green"){
		print("Green means GO!");
	}
	else if (stopLight == "All Colors"){
		print("Stop, drop, and roll");
	
	}
	else{
		print("I dont know what you mean!");
	}


}


}
