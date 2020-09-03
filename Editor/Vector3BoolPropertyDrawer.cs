using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

using REXTools.REXCore;

namespace REXTools.TransformTools
{
    [CustomPropertyDrawer(typeof(Vector3Bool))]
    public class Vector3BoolPropertyDrawer : PropertyDrawerPRO
    {
        private const int totalAxes = 3;

        private const float subLabelSpacing = 4;
        private const float bottomSpacing = 2;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.height -= bottomSpacing;

            OnGUIPRO(position, property, label, () =>
            {
                label = EditorGUI.BeginProperty(position, label, property);
                
                Rect contentRect = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

                DrawPropertyField(contentRect, new GUIContent("X"), property.FindPropertyRelative("x"), 0);
                DrawPropertyField(contentRect, new GUIContent("Y"), property.FindPropertyRelative("y"), 1);
                DrawPropertyField(contentRect, new GUIContent("Z"), property.FindPropertyRelative("z"), 2);
            });
        }

        private void DrawPropertyField(Rect position, GUIContent label, SerializedProperty property, int index)
        {
            index = Mathf.Clamp(index, 0, totalAxes - 1);
            
            // backup gui settings
            int indent = EditorGUI.indentLevel;
            float labelWidth = EditorGUIUtility.labelWidth;

            // draw properties

            float width = (position.width - (totalAxes - 1) * subLabelSpacing) / totalAxes;
            Rect contentPos = new Rect(position.x + ((width + subLabelSpacing) * index), position.y, width, position.height);

            EditorGUI.indentLevel = 0;
            EditorGUIUtility.labelWidth = EditorStyles.label.CalcSize(label).x;

            EditorGUI.PropertyField(contentPos, property, label, true);
            
            // restore gui settings
            EditorGUIUtility.labelWidth = labelWidth;
            EditorGUI.indentLevel = indent;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label) + bottomSpacing;
        }
    }
}