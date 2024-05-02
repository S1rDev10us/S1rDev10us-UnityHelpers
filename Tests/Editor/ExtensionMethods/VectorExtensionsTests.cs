using NUnit.Framework;
using S1rDev10us.UnityHelpers.ExtensionMethods;
using UnityEngine;

namespace S1rDev10us.UnityHelpers.Tests.Editor.ExtensionMethods {
	[TestFixture]
	public class VectorExtensionsTests {
		#region Vector3
		[
			Test,
			TestCase(0f, 0f, 0f),
			TestCase(1f, 0f, 0f),
			TestCase(1f, 0f, 5f),
			TestCase(1f, -3f, 0f)
		]
		public void Vector3_Add_AddsVectorsCorrectly(float x, float y, float z) {
			// Arrange
			Vector3 baseVector = Vector3.one;
			Vector3 addedVector = new(x, y, z);
			Vector3 newVector;

			// Act
			newVector = baseVector.Add(x, y, z);

			// Assert
			Assert.AreEqual(baseVector+addedVector,newVector);
		}
		[
			Test,
			TestCase(0f, 0f, 0f),
			TestCase(1f, 0f, 0f),
			TestCase(1f, 0f, 5f),
			TestCase(1f, -3f, 0f),
			TestCase(1f, -3f, null),
			TestCase(null, -3f, 0f),
			TestCase(1f, null,null),
			TestCase(null, -3f, null),
			TestCase(null, null, null),
			TestCase(1f, null, 0f)

		]
		public void Vector3_With_SetsCorrectly(float? x, float? y, float? z) {
			// Arrange
			Vector3 baseVector = Vector3.one;

			Vector3 newVector;

			// Act
			newVector = baseVector.With(x, y, z);

			// Assert
			Assert.AreEqual(x??baseVector.x,newVector.x);
			Assert.AreEqual(y??baseVector.y,newVector.y);
			Assert.AreEqual(z??baseVector.z,newVector.z);
		}


		[Test,TestCase(0.5f),TestCase(1f),TestCase(100f),TestCase(-1000f),TestCase(12356f)]

		public void Vector3_MaxMagnitude_NothingWhenMagnitudeIsUnderMax(float maxMagnitude) {
			// Arrange
			Vector3 vector = new(maxMagnitude/2f,0f,0f);
			Vector3 newVector;

			// Act
			newVector = vector.MaxMagnitude(maxMagnitude);

			// Assert
			Assert.IsTrue(newVector.magnitude<Mathf.Abs(maxMagnitude));
		}
		[Test,TestCase(0.5f),TestCase(1f),TestCase(100f),TestCase(-1000f),TestCase(12356f)]


		public void Vector3_MaxMagnitude_DecreaseMagnitudeWhenOverMax(float maxMagnitude) {
			// Arrange
			Vector3 vector = new(maxMagnitude*2f,0f,0f);
			Vector3 newVector;

			// Act
			newVector = vector.MaxMagnitude(maxMagnitude);

			// Assert
			Assert.AreEqual(Mathf.Abs(maxMagnitude),newVector.magnitude);
		}

		#endregion

		#region Vector2

		[Test,TestCase(0.5f),TestCase(1f),TestCase(100f),TestCase(-1000f),TestCase(12356f)]

		public void Vector2_MaxMagnitude_NothingWhenMagnitudeIsUnderMax(float maxMagnitude) {
			// Arrange
			Vector2 vector = new(maxMagnitude/2f,0f);
			Vector2 newVector;

			// Act
			newVector = vector.MaxMagnitude(maxMagnitude);

			// Assert
			Assert.IsTrue(newVector.magnitude<Mathf.Abs(maxMagnitude));
		}
		[Test,TestCase(0.5f),TestCase(1f),TestCase(100f),TestCase(-1000f),TestCase(12356f)]


		public void Vector2_MaxMagnitude_DecreaseMagnitudeWhenOverMax(float maxMagnitude) {
			// Arrange
			Vector2 vector = new(maxMagnitude*2f,0f);
			Vector2 newVector;

			// Act
			newVector = vector.MaxMagnitude(maxMagnitude);

			// Assert
			Assert.AreEqual(Mathf.Abs(maxMagnitude),newVector.magnitude);
		}

		#endregion
	}
}