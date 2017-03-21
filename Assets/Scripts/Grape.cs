using UnityEngine;
using System.Collections;

class Grape : IShape<GumballCreationScripts> {


	public GameObject CreateShape(GumballCreationScripts gumballCreationScript){

		//GumballCreationFactory gumballFactory = new GumballCreationFactory ();

		switch(Random.Range(1,3)){

		case 1:
			//1 - for Pink

			return gumballCreationScript.grape1;
		case 2:
			//2 - for Purple
			return gumballCreationScript.grape;
		default:
			return null;
		}

	}
}

