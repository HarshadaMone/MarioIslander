using UnityEngine;
using System.Collections;

public class GumballCreationFactory : MonoBehaviour {


	public Transform target;

	public GameObject apple, watermelon, strawberry, banana, grape1, grape, mushroom;

	private float lastBallPos = 0.0f;
	
	private const int TOTAL_NUMBER_OF_GUMBALLS_IN_THE_GAME = 20; //Total number of gumballs in the game and 
																 //these gumballs will replaced in the game for reuse.

	private GumballShapeFactory gumballFactory = new GumballShapeFactory();

	GumballCreationScripts gumballCreationScript;

	GameObject thePlayer ;
	GumballCreationScripts playerScript;


	void start(){
		thePlayer = GameObject.Find ("GumballCreation");
		playerScript = thePlayer.GetComponent<GumballCreationScripts> ();
		print ("script");
		print (playerScript);

		gumballCreationScript = gameObject.GetComponent<GumballCreationScripts>();
	}

	public float CreateGumballs(){

		thePlayer = GameObject.Find ("GumballCreation");
		playerScript = thePlayer.GetComponent<GumballCreationScripts> ();

		print ("executed");

		for (int i = 0; i < TOTAL_NUMBER_OF_GUMBALLS_IN_THE_GAME; i++) {

			switch(Random.Range(1,8)){
				
				//1 - for Blue
			case 1: case 2: case 3 : case 4:
				GameObject circleObject = (GameObject)gumballFactory.getGumballShape("circle").CreateShape(playerScript);
				createGumball(circleObject);
				break;
				//for circle
			case 5 : case 6:
				GameObject squareObject = (GameObject)gumballFactory.getGumballShape("square").CreateShape(playerScript);
				createGumball(squareObject);
				break;
				//for square
			case 7:
				createGumball((GameObject)gumballFactory.getGumballShape("star").CreateShape(playerScript));
				break;
				//for star
			default:
				break;
			}

		}

		return lastBallPos;

	}


	private void createGumball(GameObject ball){

		if (ball != null) {
			GameObject ballObject = GameObject.Instantiate (ball) as GameObject;
			ballObject.transform.parent = transform;
		
			//logic to place balls
			if (lastBallPos == 0) {
				lastBallPos = target.position.x + 50;
			} else {
				lastBallPos += Random.Range (20, 40) + (float)Random.Range (1, 6);
			}
		
			Vector3 ballPos = new Vector3 (lastBallPos, Random.Range (0, 2), transform.position.z);
			ballObject.transform.position = ballPos;
		}
		
	}

}


//Factory Method for creating Shapes of Gumballs - Start

//Concrete classes implementing the same interface - IShape - Start
class CircleGumball : IShape<GumballCreationScripts>{



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

class SquareGumball : IShape<GumballCreationScripts> {


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

class StarGumball : IShape<GumballCreationScripts> {
	public GameObject CreateShape(GumballCreationScripts gumballCreationScript){
		//GumballCreationFactory gumballFactory = new GumballCreationFactory ();

		return gumballCreationScript.mushroom;

	}
}

//Concrete classes implementing the same interface - IShape - end


//Creating Factory to Generate Objects of Classes

public class GumballShapeFactory{
	
	public IShape<GumballCreationScripts> getGumballShape(string gumballShapeType){
		
		if (gumballShapeType.Equals ("circle")) {
			return new CircleGumball ();
		} else if (gumballShapeType.Equals ("square")) {
			return new SquareGumball ();
		} else if (gumballShapeType.Equals ("star")) {
			return new StarGumball ();
		} else {
			return null;
		}
		
	}
}


//Factory Method for creating Shapes of Gumballs - end
