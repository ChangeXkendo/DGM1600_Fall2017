using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {

	public int valueOne;

	public int valueTwo;

	private int result;


	// Use this for initialization
	void Start () {
		DoMath();
		DoMathSubtract();
		DoMathMultiply();
		DoMathDivision();	
	}
	
	void DoMath (){
		result = valueOne + valueTwo;
		print(valueOne + "+" + valueTwo + "=" + result);
	}
	void DoMathSubtract (){
		result = valueOne - valueTwo;
		print(valueOne + "-" + valueTwo + "=" + result);

	}
	void DoMathMultiply (){
		result = valueOne * valueTwo;
		print (valueOne + "*" + valueTwo + "=" + result);
		

	}

	void DoMathDivision (){
		result = valueOne / valueTwo;
		print (valueOne +"/" + valueTwo + "=" + result);

	}

public class Multiples : MonoBehaviour {

	public int totalOne;

	public int totalTwo;

	public int totalThree;

	private int sum;


	//The place the equations will go//

	void equations(){
		equationsOne();
		equationsTwo();
		equationsThree();
		equationsFour();

		

    }

	void equationsOne(){
		sum = totalOne + totalTwo;
		print(totalOne + "+" + totalTwo + "=" + sum);
	}
	void equationsTwo(){
		sum = totalTwo + totalThree;
		print(totalTwo +"+"+ totalThree +"="+ sum);
	}
	void equationsThree(){
		sum = totalThree - totalTwo;
		print(totalThree +"-"+ totalTwo +"="+ sum);

	}
	void equationsFour(){
		sum = totalTwo - totalOne;
		print(totalTwo +"-"+ totalOne +"="+ sum);

	}


}	

	// Update is called once per frame
	 //void Update () {
		
	//}
}
