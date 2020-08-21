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
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!property.serializedObject.isEditingMultipleObjects)
            {
                OnGUIPRO(position, property, label, () =>
                {
                    lines = 2f;

                    //newPosition.width = EditorGUIUtility.labelWidth;

                    //GUI.Label(newPosition, property.displayName);

                    //newPosition.width = EditorGUIUtility.fieldWidth / 3f;
                    //newPosition.x = EditorGUIUtility.labelWidth;

                    //newPosition.width = EditorGUIUtility.fieldWidth;
                    //EditorGUI.IntField(newPosition, 10);

                    ////property.FindPropertyRelative("x").boolValue = GUI.Toggle(newPosition, property.FindPropertyRelative("x").boolValue, "X");

                    //newPosition.x += EditorGUIUtility.fieldWidth / 3f;

                    //property.FindPropertyRelative("y").boolValue = GUI.Toggle(newPosition, property.FindPropertyRelative("y").boolValue, "Y");

                    //newPosition.x += EditorGUIUtility.fieldWidth / 3f;

                    //property.FindPropertyRelative("z").boolValue = GUI.Toggle(newPosition, property.FindPropertyRelative("z").boolValue, "Z");


                    float nameWidth = position.width * .41f;

                    float labelWidth = 12f;
                    float fieldWidth = ((position.width - nameWidth) / 3f) - labelWidth;

                    SerializedProperty x = property.FindPropertyRelative("x");
                    SerializedProperty y = property.FindPropertyRelative("y");
                    SerializedProperty z = property.FindPropertyRelative("z");

                    float posx = position.x;

                    int indent = EditorGUI.indentLevel;

                    EditorGUI.LabelField(new Rect(position.x, position.y, nameWidth, position.height), property.displayName);
                    posx += nameWidth;

                    // Draw X
                    EditorGUI.LabelField(new Rect(posx, position.y, labelWidth, position.height), "X");
                    posx += labelWidth;
                    property.FindPropertyRelative("x").boolValue = EditorGUI.Toggle(
                        new Rect(posx, position.y, fieldWidth, position.height), property.FindPropertyRelative("x").boolValue);
                    posx += fieldWidth;

                    // Y
                    //EditorGUI.indentLevel = 0;
                    EditorGUI.LabelField(new Rect(posx, position.y, labelWidth, position.height), "Y");
                    posx += labelWidth;
                    property.FindPropertyRelative("y").boolValue = EditorGUI.Toggle(
                        new Rect(posx, position.y, fieldWidth, position.height), property.FindPropertyRelative("y").boolValue);
                    posx += fieldWidth;

                    // Z
                    //EditorGUI.indentLevel = 0;
                    EditorGUI.LabelField(new Rect(posx, position.y, labelWidth, position.height), "Z");
                    posx += labelWidth;
                    property.FindPropertyRelative("z").boolValue = EditorGUI.Toggle(
                        new Rect(posx, position.y, fieldWidth, position.height), property.FindPropertyRelative("z").boolValue);
                    posx += fieldWidth;

                    EditorGUI.indentLevel = indent;



                    newPosition.y -= lineHeight;
                    //newPosition.width = 

                });
            }
        }
    }
}