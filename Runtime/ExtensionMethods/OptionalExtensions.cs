using System;
using JetBrains.Annotations;

namespace S1rDev10us.UnityHelpers.ExtensionMethods {
	public static class OptionalExtensions {
		[PublicAPI]
		public static TClass OrNull<TClass>(this Optional<TClass> optional,[CanBeNull] TClass _=null) where TClass : class {
			if (_ != null)
				throw new ArgumentException(
					"Second argument on OrNull function is only used to separate methods and should not be assigned to",
					nameof(_));
			return optional.Enabled ? optional.Value : null;
		}
		[PublicAPI]
		public static TStruct? OrNull<TStruct>(this Optional<TStruct> optional,[CanBeNull] TStruct? _=null) where TStruct : struct {
			if (_ != null)
				throw new ArgumentException(
					"Second argument on OrNull function is only used to separate methods and should not be assigned to",
					nameof(_));
			return optional.Enabled ? optional.Value : null;
		}
	}
}