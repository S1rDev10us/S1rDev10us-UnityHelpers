using System.Collections.Generic;
using NUnit.Framework;

namespace S1rDev10us.UnityHelpers.Tests.Editor.ExtensionMethods {
	[TestFixture]
	public class ListExtensionsTests {
		#region Extract

		[Test]
		public void Extract_ReducesListLength() {
			// Arrange
			List<int> list = new() { 1 };

			// Act
			list.Extract();

			// Assert
			Assert.AreEqual(0,list.Count);

		}

		[Test]
		public void Extract_GetsFirstElement() {
			// Arrange
			List<int> list = new() { 0, 1, 2, 3, 4 };
			int itemValue;

			// Act
			itemValue = list.Extract();

			// Assert
			Assert.AreEqual(0,itemValue);

		}
		public void Extract_GetsElementAtIndex() {
			// Arrange
			List<int> list = new() { 0, 1, 2, 3, 4 };
			int itemValue;

			// Act
			itemValue = list.Extract(2);

			// Assert
			Assert.AreEqual(2,itemValue);

		}
		#endregion
	}
}