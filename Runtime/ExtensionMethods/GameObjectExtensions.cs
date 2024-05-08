using JetBrains.Annotations;
using UnityEngine;

namespace S1rDev10us.UnityHelpers.ExtensionMethods {
	public static class GameObjectExtensions {
		/// <summary>
		/// Finds the desired component on the <see cref="GameObject"/>. If it does not exist it creates it instead
		/// </summary>
		/// <param name="obj">The <see cref="GameObject"/> which you are finding the component on</param>
		/// <typeparam name="T">The component type to find</typeparam>
		/// <returns>The <see cref="MonoBehaviour"/> of type <see cref="T"/></returns>
		[PublicAPI]
		public static T GetOrAddComponent<T>(this GameObject obj) where T : Component =>
			obj.GetComponent<T>().OrNull() ?? obj.AddComponent<T>();


		/// <summary>
		/// Returns null if the object is null or if the object has been destroyed but is not null.
		/// </summary>
		/// <param name="obj">The object to be checked</param>
		/// <typeparam name="T">The type of the object</typeparam>
		/// <returns>The object or null</returns>
		[PublicAPI,CanBeNull]
		public static T OrNull<T>(this T obj) where T : Object => obj ? obj : null;

		/// <summary>
		/// Removes a GameObject, component or asset.
		///
		/// <para>
		/// This version of the function can be called on the object instead of
		/// </para>
		///
		/// https://docs.unity3d.com/ScriptReference/Object.Destroy.html
		/// </summary>
		/// <example>
		/// Here is how to call the function on a gameObject
		/// <code>
		/// GameObject obj = new GameObject();
		/// obj.Destroy();
		/// </code>
		/// </example>
		/// <param name="obj">The object to destroy.</param>
		/// <param name="T">The optional amount of time to delay before destroying the object.</param>
		[PublicAPI]
		public static void Destroy(this Object obj, float T = 0.0f) => Object.Destroy(obj, T);
	}
}