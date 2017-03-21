using UnityEngine;
using System.Collections;

//Concrete classes implementing the same interface - IShape - Start
class Strawberry : IShape<GumballCreationScripts>{

	public GameObject CreateShape(GumballCreationScripts gumballCreationScript){
		
			return gumballCreationScript.strawberry;
	}

}

