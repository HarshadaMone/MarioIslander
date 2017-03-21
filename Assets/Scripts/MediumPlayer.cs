using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public class MediumPlayer : IPlayer
	{
		private int MAX_JUMPS;
		private int numOfJumps;
		public int jumpUpForce = 450;

		private Rigidbody2D rigidbody2D;

		private RollingCharacterController rollingCharacterController;

		private int collisionCount;

		public MediumPlayer (RollingCharacterController characterController)
		{
			rollingCharacterController = characterController;
			MAX_JUMPS = 2;
		}

		public void setRigidBody(Rigidbody2D rigidbody)
		{
			rigidbody2D = rigidbody;
		}

		public void performJump(bool jump)
		{
			if (jump && numOfJumps < MAX_JUMPS){
				rigidbody2D.AddForce(new Vector2(0, jumpUpForce));
				jump = false;
				numOfJumps++;
				//animator.SetBool("Ground", false);
			}
		}

		public string getDescription()
		{
			return "medium";
		}

		public void setCollisionCount(int count)
		{
			collisionCount = count;
		}

		public void playerCollided(Collision2D collision)
		{
			if (collisionCount > 0) {
				Physics2D.IgnoreCollision (rigidbody2D.GetComponent<Collider2D> (), collision.gameObject.GetComponent<Collider2D> ());
				collisionCount--;
				Debug.Log ("collisionCount " + collisionCount);
			} else {
				rollingCharacterController.Reset ();
			}
		}
	}
}

