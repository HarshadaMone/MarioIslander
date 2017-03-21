using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public abstract class PlayerDecorator : IPlayer
	{
		private Rigidbody2D rigidbody2D;

		protected IPlayer playerCharacter;

		public PlayerDecorator (IPlayer player)
		{
			playerCharacter = player;
		}

		public void setRigidBody(Rigidbody2D rigidbody)
		{
			playerCharacter.setRigidBody (rigidbody);
		}

		public void performJump(bool jump)
		{
			playerCharacter.performJump (jump);
		}

		public string getDescription ()
		{
			return playerCharacter.getDescription ();
		}

		public void setCollisionCount(int collisionCount)
		{
			playerCharacter.setCollisionCount (collisionCount);
		}

		public void playerCollided(Collision2D collision)
		{
			playerCharacter.playerCollided(collision);
		}
	}
}

