using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

namespace S1rDev10us.UnityHelpers.ExtensionMethods {
    public static class AsyncOperationExtensions {
        /// <summary>
        /// Returns an AsyncOperation as a coroutine
        /// </summary>
        /// <param name="operation">The AsyncOperation to turn into a coroutine</param>
        /// <returns>The coroutine wrapping the async operation</returns>
        [PublicAPI]
        public static IEnumerator AsIEnumerator(this AsyncOperation operation) {
            yield return new WaitUntil(() => operation.isDone);
        }
    }
}