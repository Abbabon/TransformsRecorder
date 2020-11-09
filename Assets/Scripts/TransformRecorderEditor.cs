using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TransformRecorder))]
public class TransformsRecorderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Record Transforms", EditorStyles.miniButton))
        {
            ((TransformRecorder)target).RecordTransforms();
        }
        if (GUILayout.Button("Load Transforms", EditorStyles.miniButton))
        {
            ((TransformRecorder)target).LoadTransforms();
        }
        DrawDefaultInspector ();
    }
}