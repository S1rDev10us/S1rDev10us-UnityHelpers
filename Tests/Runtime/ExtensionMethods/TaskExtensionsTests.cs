using System.Collections;
using System.Threading.Tasks;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace S1rDev10us.UnityHelpers.Tests.Runtime.ExtensionMethods {
	[TestFixture]
	public class TaskExtensionsTests {
		#region AsIEnumerator

		[UnityTest]
		public IEnumerator AsIEnumerator_IsCompleteOnCoroutineFinish() {
			// Arrange
			Task delayTask = Task.Delay(500);
			IEnumerator coroutine = delayTask.AsIEnumerator();

			// Act
			yield return coroutine;

			// Assert
			Assert.IsTrue(delayTask.IsCompleted);
		}
		#endregion
	}
}