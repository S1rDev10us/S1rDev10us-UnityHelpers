using UnityEngine;
using System.Collections;
using System.Threading.Tasks;
using NUnit.Framework;
using S1rDev10us.UnityHelpers.ExtensionMethods;
using UnityEngine.TestTools;
using UnityEngine.Assertions;
using Assert=UnityEngine.Assertions.Assert;

namespace S1rDev10us.UnityHelpers.Tests.Runtime.ExtensionMethods {
	[TestFixture]
	public class TaskExtensionsTests {
		#region AsIEnumerator

		[UnityTest]
		public IEnumerator AsIEnumerator_IsCompleteOnCoroutineFinish() {
			// Arrange
			float startTime=Time.unscaledTime;
			const int delayInMS=1000;
			Task delayTask = Task.Delay(delayInMS);
			IEnumerator coroutine = delayTask.AsIEnumerator();

			// Act
			yield return coroutine;

			// Assert
			Assert.IsTrue(delayTask.IsCompleted);

			float duration=Time.unscaledTime-startTime;
			float error=duration-(delayInMS/1000f);
			// Should be accurate to within deltaTime
			Assert.AreApproximatelyEqual(error,0,tolerance:Time.unscaledDeltaTime);
		}
		#endregion
	}
}
