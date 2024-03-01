using JetBrains.Annotations;
using UnityEngine;

public static class Vector3Extensions {
	/// <summary>
	/// Adds the x, y and z input to the vector
	/// </summary>
	/// <param name="vector">The original vector</param>
	/// <param name="x">The number to add to the x component of the vector</param>
	/// <param name="y">The number to add to the y component of the vector</param>
	/// <param name="z">The number to add to the z component of the vector</param>
	/// <returns>The vector with the input components added to it</returns>
	[PublicAPI]
	public static Vector3 Add(this Vector3 vector, float x = 0, float y = 0, float z = 0) {
		return vector+new Vector3(x, y, z);
	}
	/// <summary>
	/// Sets the x, y and z input on the vector
	/// </summary>
	/// <param name="vector">The original vector</param>
	/// <param name="x">The number to set on the x component of the vector</param>
	/// <param name="y">The number to set on the y component of the vector</param>
	/// <param name="z">The number to set on the z component of the vector</param>
	/// <returns>The vector with the input components added to it</returns>
	[PublicAPI]
	public static Vector3 With(this Vector3 vector, float? x = null, float? y = null, float? z = null) {
		return new Vector3(x??vector.x, y??vector.y, z??vector.z);
	}
}