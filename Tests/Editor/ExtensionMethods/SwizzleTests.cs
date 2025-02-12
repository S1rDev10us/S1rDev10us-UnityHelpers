using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
using S1rDev10us.UnityHelpers.ExtensionMethods;

namespace S1rDev10us.UnityHelpers.Tests.Editor.ExtensionMethods {
	[TestFixture]
	public class SwizzleTests {
		#region Special cases

		[Test]
		public void SpecialCase_One() {
			// Arrange
			Vector2 vec2=Vector2.zero;
			Vector3 vec3=Vector3.zero;
			Vector4 vec4=Vector4.zero;

			// Act
			vec2=vec2._11();
			vec3=vec3._111();
			vec4=vec4._1111();

			// Assert
			Assert.AreEqual(vec2,Vector2.one);
			Assert.AreEqual(vec3,Vector3.one);
			Assert.AreEqual(vec4,Vector4.one);
		}
		[Test]
		public void SpecialCase_Zero() {
			// Arrange
			Vector2 vec2=Vector2.one;
			Vector3 vec3=Vector3.one;
			Vector4 vec4=Vector4.one;

			// Act
			vec2=vec2._00();
			vec3=vec3._000();
			vec4=vec4._0000();

			// Assert
			Assert.AreEqual(vec2,Vector2.zero);
			Assert.AreEqual(vec3,Vector3.zero);
			Assert.AreEqual(vec4,Vector4.zero);
		}
		[Test]
		public void SpecialCase_Self() {
			Vector2 vec2=Vector2.one;
			Vector3 vec3=Vector3.one;
			Vector4 vec4=Vector4.one;

			Assert.AreEqual(vec2._xy(),vec2);
			Assert.AreEqual(vec3._xyz(),vec3);
			Assert.AreEqual(vec4._xyzw(),vec4);
		}
		#endregion
	}
}
