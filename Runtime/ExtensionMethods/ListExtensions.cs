using System.Collections.Generic;
using JetBrains.Annotations;

public static class ListExtensions {
	/// <summary>
	/// Get the first element from the list and then remove it
	/// </summary>
	/// <param name="list">The list to get the first element from</param>
	/// <typeparam name="T">The type of objects that the list contains</typeparam>
	/// <returns>The first element from the list</returns>
	[PublicAPI]
	public static T Extract<T>(this List<T> list) {
		if (list.Count==0) return default;
		T obj = list[0];
		list.RemoveAt(0);
		return obj;
	}
}