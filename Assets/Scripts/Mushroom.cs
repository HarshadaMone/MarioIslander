using UnityEngine;
using System.Collections;

//Concrete classes implementing the same interface - IShape - end
class Mushroom : IShape<GumballCreationScripts> {
	public GameObject CreateShape(GumballCreationScripts gumballCreationScript){
		//GumballCreationFactory gumballFactory = new GumballCreationFactory ();

		return gumballCreationScript.mushroom;

	}
}

