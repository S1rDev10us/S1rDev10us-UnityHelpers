using JetBrains.Annotations;
using UnityEngine;

public static class VectorExtensions {

	#region Vector3



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
	/// <summary>
	/// Returns the vector with the magnitude constrained to be less than the input max which is 1 by default
	/// </summary>
	/// <param name="vector">The vector to constrained</param>
	/// <param name="max">The maximium magnitude</param>
	/// <returns>The constrained vector</returns>
	[PublicAPI]
	public static Vector3 MaxMagnitude(this Vector3 vector, float max = 1) {
		max = Mathf.Abs(max);
		if (vector.magnitude > max) {
			return vector.normalized * max;
		}

		return vector;
	}
	#endregion

	#region Vector2
	/// <summary>
	/// Returns the vector with the magnitude constrained to be less than the input max which is 1 by default
	/// </summary>
	/// <param name="vector">The vector to constrained</param>
	/// <param name="max">The maximium magnitude</param>
	/// <returns>The constrained vector</returns>
	[PublicAPI]
	public static Vector2 MaxMagnitude(this Vector2 vector, float max = 1) {
		max = Mathf.Abs(max);
		if (vector.magnitude > max) {
			return vector.normalized * max;
		}

		return vector;
	}
	#endregion

}