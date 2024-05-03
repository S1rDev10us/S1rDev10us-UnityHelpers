using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace S1rDev10us.UnityHelpers {
	[Serializable]
	public struct Optional<T> {
		[SerializeField]
		bool enabled;

		[SerializeField]
		T value;

		public bool Enabled => enabled;
		public T Value => value;

		public Optional(T initialValue) {
			value = initialValue;
			enabled = true;
		}
		public Optional(T initialValue,bool initialState) {
			value = initialValue;
			enabled = initialState;
		}
		public static implicit operator T(Optional<T> optional) {
			return optional.value;
		}
		public static implicit operator Optional<T>(T value) {
			return new Optional<T>(value);
		}

		public static implicit operator bool(Optional<T> optional) {
			return optional.enabled;
		}
	}
}