using System;
using NUnit.Framework;
using S1rDev10us.UnityHelpers.ExtensionMethods;

namespace S1rDev10us.UnityHelpers.Tests.Editor.ExtensionMethods {
	public class EmptyClass{
	}

	[TestFixture]
	public class OptionalExtensionsTests {
		#region OrNull
		#region OrNull_Struct

		[Test]
		public void OrNull_Struct_ReturnsValue(){
			// Arrange
			const float value=3.5f;
			Optional<float> optional = new(value,true);
			float? result;

			// Act
			result=optional.OrNull();

			// Assert
			Assert.AreEqual(value,result);
		}
		[Test]
		public void OrNull_Struct_ReturnsNull() {
			// Arrange
			const float value=3.5f;
			Optional<float> optional = new(value,false);
			float? result;

			// Act
			result=optional.OrNull();

			// Assert
			Assert.IsNull(result);
		}
		[Test, TestCase(true),TestCase(false)]
		public void OrNull_Struct_ThrowsError(bool enabled) {
			// Arrange
			const float value=3.5f;
			Optional<float> optional = new(value, enabled);
			bool threwError = false;

			// Act
			try {
				optional.OrNull(_:value);
			} catch (ArgumentException) {
				threwError = true;
			}

			// Assert
			Assert.IsTrue(threwError);
		}
		#endregion
		#region OrNull_Class
		[Test]
		public void OrNull_Class_ReturnsValue(){
			// Arrange
			EmptyClass value=new();
			Optional<EmptyClass> optional = new(value,true);
			EmptyClass result;

			// Act
			result=optional.OrNull();

			// Assert
			Assert.AreEqual(value,result);
		}
		[Test]
		public void OrNull_Class_ReturnsNull() {
			// Arrange
			EmptyClass value = new();
			Optional<EmptyClass> optional = new(value,false);
			EmptyClass result;

			// Act
			result=optional.OrNull();

			// Assert
			Assert.IsNull(result);
		}

		[Test, TestCase(true),TestCase(false)]
		public void OrNull_Class_ThrowsError(bool enabled) {
			// Arrange
			EmptyClass value=new();
			Optional<EmptyClass> optional = new(value, enabled);
			bool threwError = false;

			// Act
			try {
				optional.OrNull(_:value);
			} catch (ArgumentException) {
				threwError = true;
			}

			// Assert
			Assert.IsTrue(threwError);
		}
		#endregion
		#endregion
	}
}