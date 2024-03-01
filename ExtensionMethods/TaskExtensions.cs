
	using System.Collections;
	using System.Threading.Tasks;
	using JetBrains.Annotations;
	using UnityEngine;

	public static class TaskExtensions {
		/// <summary>
		/// Returns an async/await function/task as a coroutine
		/// </summary>
		/// <param name="task">The task to turn into a coroutine</param>
		/// <returns>The coroutine wrapping the async operation</returns>
		[PublicAPI]
		public static IEnumerator AsIEnumerator(this Task task) {
			yield return new WaitUntil(() => task.IsCompleted);
		}
	}
