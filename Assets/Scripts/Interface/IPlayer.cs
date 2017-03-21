using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public interface IPlayer
	{
		void setRigidBody(Rigidbody2D rigidbody);
		void performJump(bool jump);
		string getDescription();
		void setCollisionCount (int collisionCount);
		void playerCollided (Collision2D collision);
	}
}

