using NUnit.Framework;

namespace S1rDev10us.UnityHelpers.Tests.Editor {
	[TestFixture]
	public class OptionalTests {
		[Test]
		public void Implicit_ToValue() {
			// Arrange
			Optional<float> optional = new(3.5f);
			float value;

			// Act
			value = optional;

			// Assert
			Assert.AreEqual(3.5f, value);
		}

		[Test]
		public void Implicit_FromValue() {
			// Arrange
			Optional<float> optional;

			// Act
			optional = 3.5f;

			// Assert
			Assert.AreEqual(3.5f, optional.Value);
		}

		[Test]
		[TestCase(true), TestCase(false), TestCase(null)]
		public void Implicit_ToEnabled(bool? expectedValue) {
			// Arrange
			Optional<float> optional = expectedValue is null
				? new Optional<float>(3.5f)
				: new Optional<float>(3.5f, (bool)expectedValue);
			bool value;

			// Act
			value = optional;

			// Assert
			Assert.AreEqual(expectedValue ?? true, value);
		}
		[Test]
		public void GetValueReturnsInput() {
			// Arrange
			Optional<float> optional=new(3.5f);
			float value;
			// Act
			value = optional.Value;

			// Assert
			Assert.AreEqual(3.5f, value);
		}
	}
}