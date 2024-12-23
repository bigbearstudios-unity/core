﻿using UnityEditor;
using UnityEngine;

namespace BBUnity.Editor {
    [CustomPropertyDrawer(typeof(EditorAttributes.LayerAttribute))]
    class LayerAttributeDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            property.intValue = EditorGUI.LayerField(position, label, property.intValue);
        }
    }
}
