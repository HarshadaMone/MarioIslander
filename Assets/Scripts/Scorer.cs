//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using AssemblyCSharp;
using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	public class Scorer
	{
		private static ScoreSubject scoreSubject = new ScoreSubject();

		private static SpriteDecorator spriteDecorator = new SpriteDecorator();

		private static TimeScore timeScore = new TimeScore (scoreSubject);
		private static PointScore pointScore = new PointScore (scoreSubject);

		private static RollingCharacterController rollingCharacterController;
		private static SpeedManager speedManager;
		private static int count = 0;

		public Scorer ()
		{
			//scoreSubject = new ScoreSubject();
			//timeScore = new TimeScore (scoreSubject);
			//pointScore = new PointScore (scoreSubject);
		}

		public static void setCharacter(RollingCharacterController character)
		{
			rollingCharacterController = character;
		}

		public static void setSpeeedManager(SpeedManager sManager)
		{
			speedManager = sManager;
		}

		public static void reset()
		{
			count = 0;
		}

		//Score adder for gumball
		public static void ScoreAdderForGumballs(string objectName ){

			//Debug.Log (scoreSubject.getScore ());

			switch(objectName){

				case "green":case "blue":case "yellow":case "red":
				pointScore.AddScore(2);
					//add 2 points
					break;
				case "pink":case "purple":
				pointScore.AddScore(4);
					//add 4 points
					break;
				case "star":
				pointScore.AddScore(6);
					//add 6 points
					break;
			}

			count++;

			/*if(objectNameCount > 2 ) {
				Debug.Log("Before calling Decorator");



			}*/

			if (count == 5) {
				speedManager.SetNewSpeed ("medium");
				RollingCharacterController newController =  spriteDecorator.changeVector(rollingCharacterController, 16f);

				rollingCharacterController = newController;
				//rollingCharacterController.playerCharacter = new ConcretePlayerDecorator(new MediumPlayer (rollingCharacterController));

			} else if (count == 10) {
				speedManager.SetNewSpeed ("high");
				RollingCharacterController newController =  spriteDecorator.changeVector(rollingCharacterController, 22f);

				rollingCharacterController = newController;
				//rollingCharacterController.playerCharacter = new ConcretePlayerDecorator(new HighPlayer (rollingCharacterController));
			}
		}

		public static void ScoreAdderForTime(int score){
			timeScore.AddScore (score);
		}

		public static int GetScore(){
			return scoreSubject.getScore ();
		}

		public static void SetScore(int score){
			scoreSubject.setScore (score);
		}

	}
}

