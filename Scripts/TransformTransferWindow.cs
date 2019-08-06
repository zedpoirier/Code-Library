// Author: Zed Poirier
using UnityEngine;
using UnityEditor;
/// <summary>
/// Used in combination with the TransformTransfer script. This script must be inside the Editor 
/// foler. See that script for detailed instructions on how to use this script.
/// </summary>
[CustomEditor(typeof(TransformTransfer))]
public class TransformTransferWindow : Editor {

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        TransformTransfer tt = (TransformTransfer)target;

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Save Transforms")) {
            tt.SaveTransforms();
        }
        if (GUILayout.Button("Apply Transforms")) {
            tt.ApplyTransforms();
        }
        GUILayout.EndHorizontal();
    }
}
