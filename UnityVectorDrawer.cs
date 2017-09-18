using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace OH
{
    public enum VectorDrawerLayoutMode
    {
        SingleLine,
        TwoLines,
        Dynamic
    }

    public partial class UnityVectorDrawer : PropertyDrawer
    {
        public const VectorDrawerLayoutMode LayoutMode = VectorDrawerLayoutMode.SingleLine;
        public const float SingleLineHeight = 16f;
        public const float TwoLinesHeight = 34f;
        public const float DynamicSwitchWidth = 333;

        // You could factor in stuff like the vector name length, nComponents, etc.
        public static float NameLabelWidth(bool useTwoLines, float width, int nComponents, GUIContent label)
        {
            if (useTwoLines)
            {
                return 0.0f; // Default
            }

            return width / 3;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            switch (LayoutMode)
            {
                case VectorDrawerLayoutMode.SingleLine: { return SingleLineHeight; }
                case VectorDrawerLayoutMode.TwoLines: { return TwoLinesHeight; }
            }

            return Screen.width < DynamicSwitchWidth ? TwoLinesHeight : SingleLineHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!property.hasVisibleChildren)
            {
                EditorGUI.PropertyField(position, property, label, true);
            }

            bool useTwoLines = position.height > SingleLineHeight;

            int nComponents = 0;
            foreach (SerializedProperty childProp in property.Copy())
            {
                nComponents++;
            }

            EditorGUIUtility.labelWidth = NameLabelWidth(useTwoLines, position.width, nComponents, label);

            label = EditorGUI.BeginProperty(position, label, property);
            {
                Rect contentPosition = EditorGUI.PrefixLabel(position, label);

                if (useTwoLines)
                {
                    position.height = SingleLineHeight;
                    EditorGUI.indentLevel += 1;
                    contentPosition = EditorGUI.IndentedRect(position);
                    contentPosition.y += (TwoLinesHeight - SingleLineHeight);
                }

                EditorGUI.indentLevel = 0;
                EditorGUIUtility.labelWidth = 14f;
                contentPosition.width /= nComponents;

                foreach (SerializedProperty childProp in property)
                {
                    EditorGUI.PropertyField(contentPosition, childProp, new GUIContent(childProp.name.ToUpper()));
                    contentPosition.x += contentPosition.width;
                }
            }
            EditorGUI.EndProperty();
        }
    }
}