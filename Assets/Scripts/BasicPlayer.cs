using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public class BasicPlayer : IPlayer
	{
		private int MAX_JUMPS;
		private int numOfJumps;
		public int jumpUpForce = 450;

		private Rigidbody2D rigidbody2D;

		private RollingCharacterController rollingCharacterController;

		private int collisionCount;

		public BasicPlayer (RollingCharacterController characterController)
		{
			rollingCharacterController = characterController;
		}

		public void setRigidBody(Rigidbody2D rigidbody)
		{
			rigidbody2D = rigidbody;
		}

		public void performJump(bool jump)
		{
			if (jump){
				rigidbody2D.AddForce (new Vector2 (0, jumpUpForce));
				jump = false;
			}
		}

		public string getDescription()
		{
			return "basic";
		}

		public void setCollisionCount(int count)
		{
			collisionCount = count;
		}

		public void playerCollided(Collision2D collision)
		{
			rollingCharacterController.Reset ();
		}
	}
}

