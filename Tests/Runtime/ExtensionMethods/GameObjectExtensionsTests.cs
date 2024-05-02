using System.Collections;
using NUnit.Framework;
using S1rDev10us.UnityHelpers.ExtensionMethods;
using UnityEngine;
using UnityEngine.TestTools;

namespace S1rDev10us.UnityHelpers.Tests.Runtime.ExtensionMethods {
	[TestFixture]
	public class GameObjectExtensionsTests {
		#region GetOrAddComponent
		[Test]
		public void GetOrAddComponent_AddsWhenMissing() {
			// Arrange
			GameObject obj = new GameObject();

			// Act
			obj.GetOrAddComponent<EmptyMonoBehaviour>();

			// Assert
			Assert.IsTrue(obj.GetComponent<EmptyMonoBehaviour>());
		}

		[Test]
		public void GetOrAddComponent_GetsWhenFound() {
			// Arrange
			GameObject obj = new();
			EmptyMonoBehaviour monoBehaviour = obj.AddComponent<EmptyMonoBehaviour>();
			EmptyMonoBehaviour foundMonoBehaviour;

			// Act
			foundMonoBehaviour = obj.GetOrAddComponent<EmptyMonoBehaviour>();

			// Assert
			Assert.AreEqual(monoBehaviour.GetInstanceID(), foundMonoBehaviour.GetInstanceID());
		}
		#endregion
		#region OrNull

		[Test]
		public void OrNull_IsNullWhenNotFound() {
			// Arrange
			GameObject obj = new();
			EmptyMonoBehaviour monoBehaviour=obj.GetComponent<EmptyMonoBehaviour>();
			EmptyMonoBehaviour foundMonoBehaviour;

			// Act
			foundMonoBehaviour = monoBehaviour.OrNull();

			// Assert
			Assert.IsNull(foundMonoBehaviour);
		}

		[Test]
		public void OrNull_IsNotNullWhenFound() {
			// Arrange
			GameObject obj = new();
			EmptyMonoBehaviour monoBehaviour=obj.AddComponent<EmptyMonoBehaviour>();

			EmptyMonoBehaviour foundMonoBehaviour;

			// Act
			foundMonoBehaviour = monoBehaviour.OrNull();

			// Assert
			Assert.NotNull(foundMonoBehaviour);
		}

		[Test]
		public void OrNull_IsNullWhenDestroyed() {
			// Arrange
			GameObject obj = new();
			EmptyMonoBehaviour monoBehaviour=obj.AddComponent<EmptyMonoBehaviour>();
			EmptyMonoBehaviour foundMonoBehaviour;

			// Act
			Object.DestroyImmediate(monoBehaviour);
			foundMonoBehaviour = monoBehaviour.OrNull();

			// Assert
			Assert.IsNull(foundMonoBehaviour);
		}

		#endregion
		#region Destroy

		[UnityTest]
		public IEnumerator Destroy_ObjectIsDestroyed() {
			//Arrange
			GameObject obj = new();
			EmptyMonoBehaviour monoBehaviour = obj.AddComponent<EmptyMonoBehaviour>();

			// Act
			monoBehaviour.Destroy();
			// Wait 1 frame so that unity actually deletes monobehaviour
			yield return null;

			// Assert
			Assert.IsNull(monoBehaviour.OrNull());
		}
		#endregion
	}
}