using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public class SpriteDecorator : ISpriteDecorator
	{

		public Sprite AstronautSpriteIdle;
		public Sprite alien;

		public RollingCharacterController changeVector (RollingCharacterController character, float size)
		{
			character.setVectorDetail(new Vector3(size, size, 0));

			Debug.Log("Vector details" + character.getVectorDetail());

			character.transform.localScale = character.getVectorDetail();

			return character;
		}
	}
}

