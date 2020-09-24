using NUnit.Framework;
using UnityEditor;

namespace Kogane.Internal
{
	internal sealed class UseIncrementalGCTest
	{
		[Category( "Kogane" )]
		[Test]
		public void Incremental_GC_が有効になっているか()
		{
			Assert.IsTrue( PlayerSettings.gcIncremental );
		}
	}
}