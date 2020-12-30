using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;


public class SetVertexIdToUV : EditorWindow
{
    private Mesh target;

    [MenuItem("Tools/Open SetVertexIdToUV2")]
    private static void Open()
    {
        var editorWindow = EditorWindow.GetWindow(typeof(SetVertexIdToUV)) as SetVertexIdToUV;
        editorWindow.Show();
    }

    private void OnGUI()
    {
        target = EditorGUILayout.ObjectField("Target Mesh", target, typeof(Mesh), false) as Mesh;

        if (GUILayout.Button("Bake"))
        {
            Bake();
        }
    }

    private void Bake()
    {
        int vertexCount = target.vertexCount;
        var uv2 = new Vector2[vertexCount];
        for (int i = 0; i < vertexCount; i++)
        {
            uv2[i] = new Vector2(i, i);
        }

        target.uv2 = uv2;
        EditorUtility.SetDirty(target);
    }
}