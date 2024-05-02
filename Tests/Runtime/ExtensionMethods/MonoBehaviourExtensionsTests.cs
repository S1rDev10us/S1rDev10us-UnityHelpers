using NUnit.Framework;
using S1rDev10us.UnityHelpers.ExtensionMethods;
using UnityEngine;

namespace S1rDev10us.UnityHelpers.Tests.Runtime.ExtensionMethods {
	[TestFixture]
	public class MonoBehaviourExtensionsTests {
		#region GetOrAddComponent
		[Test]
		public void GetOrAddComponent_AddsWhenMissing() {
			// Arrange
			GameObject obj = new GameObject();
			EmptyMonoBehaviourCopy mb = obj.AddComponent<EmptyMonoBehaviourCopy>();

			// Act
			mb.GetOrAddComponent<EmptyMonoBehaviour>();

			// Assert
			Assert.IsTrue(obj.GetComponent<EmptyMonoBehaviour>());
		}

		[Test]
		public void GetOrAddComponent_GetsWhenFound() {
			// Arrange
			GameObject obj = new();
			EmptyMonoBehaviourCopy otherMonoBehaviour = obj.AddComponent<EmptyMonoBehaviourCopy>();
			EmptyMonoBehaviour monoBehaviour = obj.AddComponent<EmptyMonoBehaviour>();
			EmptyMonoBehaviour foundMonoBehaviour;

			// Act
			foundMonoBehaviour = otherMonoBehaviour.GetOrAddComponent<EmptyMonoBehaviour>();

			// Assert
			Assert.AreEqual(monoBehaviour.GetInstanceID(), foundMonoBehaviour.GetInstanceID());
		}
		#endregion
	}
}