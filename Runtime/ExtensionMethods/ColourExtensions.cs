using UnityEngine;

namespace S1rDev10us.UnityHelpers.ExtensionMethods {
	public static class ColourExtensions {
		public static Color With(this Color colour,
			float? r = null,
			float? g = null,
			float? b = null,
			float? a = null) {
			return new Color(r ?? colour.r, g ?? colour.g, b ?? colour.b, a ?? colour.a);
		}
	}
}