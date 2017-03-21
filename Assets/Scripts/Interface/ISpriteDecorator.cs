using System;

namespace AssemblyCSharp
{
	public interface ISpriteDecorator
	{
		RollingCharacterController changeVector(RollingCharacterController character, float size);
	}
}

