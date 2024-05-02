using NUnit.Framework;
using S1rDev10us.UnityHelpers.ExtensionMethods;
using UnityEngine;

namespace S1rDev10us.UnityHelpers.Tests.Editor.ExtensionMethods {
	[TestFixture]
	public class ColourExtensionsTests {


		[Test]
		public void With_AffectsNothingWhenEmpty() {
			// Arrange
			Color a = Color.blue;
			Color b;

			// Act
			b = a.With();

			// Assert
			Assert.AreEqual(Color.blue, b);
		}

		[Test, TestOf(nameof(ColourExtensions))]
		public void With_AffectsOnlyDesiredColors() {
			// Arrange
			Color a = Color.blue;
			Color b;

			// Act
			b = a.With(r: 1f);

			// Assert
			Assert.AreEqual(new Color(1, 0, 1, 1), b);
		}


	}
}