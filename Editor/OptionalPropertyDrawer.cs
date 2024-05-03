using S1rDev10us.UnityHelpers;
using UnityEditor;
using UnityEngine;

namespace Editor {
	[CustomPropertyDrawer(typeof(Optional<>))]
	public class OptionalPropertyDrawer : PropertyDrawer {
		public override void OnGUI(Rect position,
			SerializedProperty property,
			GUIContent label) {

			SerializedProperty value = property.FindPropertyRelative("value");
			SerializedProperty enabled = property.FindPropertyRelative("enabled");
			if (value == null) {
				Debug.LogError($"Type of optional value on variable \"{label.text}\" is not serializable");
				EditorGUI.LabelField(position,label);
				return;
			}

			EditorGUI.BeginProperty(position, label, property);
			{

				position.width -= 24;
				EditorGUI.BeginDisabledGroup(!enabled.boolValue);
				{
					EditorGUI.PropertyField(position, value, label, true);

				}
				EditorGUI.EndDisabledGroup();

				int indent = EditorGUI.indentLevel;
				EditorGUI.indentLevel = 0;

				{
					position.x += position.width + 24;
					position.height = position.width = EditorGUI.GetPropertyHeight(enabled);
					position.x -= position.width;
					EditorGUI.PropertyField(position, enabled, GUIContent.none);

				}

				EditorGUI.indentLevel = indent;
			}

			EditorGUI.EndProperty();
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
			SerializedProperty value = property.FindPropertyRelative("value");
			if(value!=null) return EditorGUI.GetPropertyHeight(value);
			return 24;
		}
	}
}