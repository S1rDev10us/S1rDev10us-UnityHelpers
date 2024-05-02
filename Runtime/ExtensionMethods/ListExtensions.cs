using System.Collections.Generic;
using JetBrains.Annotations;

public static class ListExtensions {
	/// <summary>
	/// Return the first or specified element from the list and remove it
	/// </summary>
	/// <param name="list">The list to get the first element from</param>
	/// <param name="index">The position to remove an element from. Defaults to the first position</param>
	/// <typeparam name="T">The type of objects that the list contains</typeparam>
	/// <returns>The first element from the list</returns>
	[PublicAPI]
	public static T Extract<T>(this List<T> list,int index=0) {
		if (list.Count==0) return default;
		T obj = list[index];
		list.RemoveAt(index);
		return obj;
	}
}