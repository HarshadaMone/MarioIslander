using System;

namespace AssemblyCSharp
{
	public class ConcretePlayerDecorator : PlayerDecorator
	{
		public ConcretePlayerDecorator (IPlayer player) : base (player)
		{
			avoidCollision (playerCharacter);
		}

		public void performJump(bool jump)
		{
			playerCharacter.performJump (jump);
		}

		public void avoidCollision(IPlayer player)
		{
			if (player.getDescription ().Equals ("basic")) {
				player.setCollisionCount (0);
			}
			else if (player.getDescription ().Equals ("medium")) {
				player.setCollisionCount (1);
			}
			else if (player.getDescription ().Equals ("high")) {
				player.setCollisionCount (2);
			}
		}
	}
}

