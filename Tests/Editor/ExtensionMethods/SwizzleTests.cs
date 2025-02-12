using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
using S1rDev10us.UnityHelpers.ExtensionMethods;

namespace S1rDev10us.UnityHelpers.Tests.Editor.ExtensionMethods {
	[TestFixture]
	public class SwizzleTests {
		#region Normal cases
		[Test,
			TestCase(0f, 0f, 0f,0f),
			TestCase(0f, 1f, 2f,4f),
			TestCase(1f, 0f, 0f,0f),
			TestCase(0f, 1f, 0f,0f),
			TestCase(0f, 0f, 1f,0f),
			TestCase(0f, 0f, 0f,1f),
		]
		public void NormalCase_yx(float x, float y, float z, float w){
			Vector2 vec2=new Vector2(x,y);
			Vector3 vec3=new Vector3(x,y,z);
			Vector4 vec4=new Vector4(x,y,z,w);

			Vector2 yx=new Vector2(y,x);

			Assert.AreEqual(vec2._yx(),yx);
			Assert.AreEqual(vec3._yx(),yx);
			Assert.AreEqual(vec4._yx(),yx);
		}
		[Test,
			TestCase(0f, 0f, 0f,0f),
			TestCase(0f, 1f, 2f,4f),
			TestCase(1f, 0f, 0f,0f),
			TestCase(0f, 1f, 0f,0f),
			TestCase(0f, 0f, 1f,0f),
			TestCase(0f, 0f, 0f,1f),
		]
		public void NormalCase_yy(float x, float y, float z, float w){
			Vector2 vec2=new Vector2(x,y);
			Vector3 vec3=new Vector3(x,y,z);
			Vector4 vec4=new Vector4(x,y,z,w);

			Vector2 yy=new Vector2(y,y);

			Assert.AreEqual(vec2._yy(),yy);
			Assert.AreEqual(vec3._yy(),yy);
			Assert.AreEqual(vec4._yy(),yy);
		}
		#endregion

		#region Special cases
		[Test,
			TestCase(0f, 0f, 0f,0f),
			TestCase(0f, 1f, 2f,4f),
			TestCase(1f, 0f, 0f,0f),
			TestCase(0f, 1f, 0f,0f),
			TestCase(0f, 0f, 1f,0f),
			TestCase(0f, 0f, 0f,1f),]
		public void SpecialCase_One(float x,float y,float z, float w) {
			// Arrange
			Vector2 vec2=new Vector2(x,y);
			Vector3 vec3=new Vector3(x,y,z);
			Vector4 vec4=new Vector4(x,y,z,w);

			// Act
			vec2=vec2._11();
			vec3=vec3._111();
			vec4=vec4._1111();

			// Assert
			Assert.AreEqual(vec2,Vector2.one);
			Assert.AreEqual(vec3,Vector3.one);
			Assert.AreEqual(vec4,Vector4.one);
		}
		[Test,
			TestCase(0f, 0f, 0f,0f),
			TestCase(0f, 1f, 2f,4f),
			TestCase(1f, 0f, 0f,0f),
			TestCase(0f, 1f, 0f,0f),
			TestCase(0f, 0f, 1f,0f),
			TestCase(0f, 0f, 0f,1f),]
		public void SpecialCase_Zero(float x,float y,float z, float w) {
			// Arrange
			Vector2 vec2=new Vector2(x,y);
			Vector3 vec3=new Vector3(x,y,z);
			Vector4 vec4=new Vector4(x,y,z,w);

			// Act
			vec2=vec2._00();
			vec3=vec3._000();
			vec4=vec4._0000();

			// Assert
			Assert.AreEqual(vec2,Vector2.zero);
			Assert.AreEqual(vec3,Vector3.zero);
			Assert.AreEqual(vec4,Vector4.zero);
		}
		[Test,
			TestCase(0f, 0f, 0f,0f),
			TestCase(0f, 1f, 2f,4f),
			TestCase(1f, 0f, 0f,0f),
			TestCase(0f, 1f, 0f,0f),
			TestCase(0f, 0f, 1f,0f),
			TestCase(0f, 0f, 0f,1f),]
		public void SpecialCase_Self(float x,float y,float z, float w) {
			Vector2 vec2=new Vector2(x,y);
			Vector3 vec3=new Vector3(x,y,z);
			Vector4 vec4=new Vector4(x,y,z,w);

			Assert.AreEqual(vec2._xy(),vec2);
			Assert.AreEqual(vec3._xyz(),vec3);
			Assert.AreEqual(vec4._xyzw(),vec4);
		}
		#endregion
	}
}
