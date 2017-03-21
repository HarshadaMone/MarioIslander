using UnityEngine;
using System.Collections;

class NormalFruit : IShape<GumballCreationScripts>{



	public GameObject CreateShape(GumballCreationScripts gumballCreationScript){

		//GumballCreationFactory gumballFactory = new GumballCreationFactory ();


		switch(Random.Range(1,5)){

		case 1:
			//1 - for Blue
			return gumballCreationScript.apple;
		case 2:
			//2 - for Green
			return gumballCreationScript.watermelon;
		case 3:
			//3 - for Red
			return gumballCreationScript.strawberry;
		case 4:
			//4 - for Yellow
			return gumballCreationScript.banana;
		default:
			return null;
		}

	}

}
