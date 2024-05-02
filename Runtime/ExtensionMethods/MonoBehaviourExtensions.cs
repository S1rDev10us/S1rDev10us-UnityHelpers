using JetBrains.Annotations;
using UnityEngine;

namespace S1rDev10us.UnityHelpers.ExtensionMethods {
	public static class MonoBehaviourExtensions {
		/// <summary>
		/// Finds the desired component on the <see cref="GameObject"/> that the <see cref="MonoBehaviour"/> belongs to. If it does not exist it creates it instead
		/// </summary>
		/// <param name="obj">The <see cref="MonoBehaviour"/> which you are finding the component on</param>
		/// <typeparam name="T">The component type to find</typeparam>
		/// <returns>The <see cref="MonoBehaviour"/> of type <see cref="T"/></returns>
		[PublicAPI]
		public static T GetOrAddComponent<T>(this MonoBehaviour obj) where T : Component =>
			obj.gameObject.GetOrAddComponent<T>();

		[PublicAPI]
		public static T AddComponent<T>(this MonoBehaviour obj) where T : Component => obj.gameObject.AddComponent<T>();
	}
}