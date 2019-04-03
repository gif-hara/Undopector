using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using System;

public class UndopectorWindow : EditorWindow
{
    private static UndopectorWindow instance;

    private List<int> instanceIds = new List<int>();

    private int currentIndex = 0;

    private bool registerSelection = true;

    private Vector2 scrollPosition;

    private static readonly Vector2 WindowMinSize = new Vector2(80, 24);

    private static readonly GUILayoutOption[] ButtonGUILayoutOptions =
    {
        GUILayout.Width(24),
        GUILayout.Height(18),
    };



    [MenuItem("Window/Undopector Floating Window")]
    private static void OpenAsUtility()
    {
        CreateInstance();
        instance.ShowUtility();
        instance.minSize = WindowMinSize;
        var position = instance.position;
        position.x = 320;
        position.y = 240;
        position.width = WindowMinSize.x;
        position.height = WindowMinSize.y;
        instance.position = position;
    }

    [MenuItem("Window/Undopector")]
    private static void Open()
    {
        CreateInstance();
        instance.Show();
    }

    private static void CreateInstance()
    {
        CloseInstance();
        if (instance == null)
        {
            instance = CreateInstance<UndopectorWindow>();
        }

        instance.titleContent.text = "Undopector";
    }

    private static void CloseInstance()
    {
        if(instance == null)
        {
            return;
        }

        instance.Close();
        instance = null;
    }

    void OnGUI()
    {
        this.DrawUndoRedoButtons();
        GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(1));
        this.DrawSelectedInstanceIdList();
    }

    void OnSelectionChange()
    {
        var instanceId = Selection.activeInstanceID;
        if(this.registerSelection && instanceId != 0)
        {
            if (this.currentIndex < this.instanceIds.Count - 1)
            {
                this.instanceIds = new List<int>(this.instanceIds.GetRange(0, this.currentIndex + 1));
            }

            if(this.instanceIds.Count <= 0 || this.instanceIds[this.instanceIds.Count - 1] != instanceId)
            {
                this.instanceIds.Add(instanceId);
                this.currentIndex = this.instanceIds.Count - 1;
            }
        }

        this.registerSelection = true;
        this.Repaint();
    }

    private void DrawUndoRedoButtons()
    {
        using (new GUILayout.HorizontalScope())
        {
            EditorGUI.BeginDisabledGroup(this.currentIndex <= 0);
            if (GUILayout.Button("<", ButtonGUILayoutOptions))
            {
                this.registerSelection = false;
                this.currentIndex--;
                Selection.activeInstanceID = this.instanceIds[this.currentIndex];
            }
            EditorGUI.EndDisabledGroup();

            EditorGUI.BeginDisabledGroup(this.currentIndex >= this.instanceIds.Count - 1);
            if (GUILayout.Button(">", ButtonGUILayoutOptions))
            {
                this.registerSelection = false;
                this.currentIndex++;
                Selection.activeInstanceID = this.instanceIds[this.currentIndex];
            }
            EditorGUI.EndDisabledGroup();
        }
    }

    private void DrawSelectedInstanceIdList()
    {
        if(!this.CanDrawSelectedInstanceIdList)
        {
            return;
        }

        using (var scrollView = new GUILayout.ScrollViewScope(this.scrollPosition))
        {
            using (var iconSize = new EditorGUIUtility.IconSizeScope(Vector2.one * 14))
            {
                for (var i = 0; i < this.instanceIds.Count; i++)
                {
                    this.DrawChangeSelectionButton(i);
                }
            }

            this.scrollPosition = scrollView.scrollPosition;
        }
    }

    private bool CanDrawSelectedInstanceIdList
    {
        get
        {
            return this.position.width > WindowMinSize.x || this.position.height > WindowMinSize.y;
        }
    }

    private void DrawChangeSelectionButton(int instanceIdsIndex)
    {
        var instanceId = this.instanceIds[instanceIdsIndex];

        using (new EditorGUILayout.HorizontalScope())
        {
            if (this.currentIndex == instanceIdsIndex)
            {
                GUILayout.Box("", GUI.skin.GetStyle("Foldout"), GUILayout.Width(18));
            }
            using (new EditorGUI.DisabledGroupScope(this.currentIndex == instanceIdsIndex))
            {
                var obj = EditorUtility.InstanceIDToObject(instanceId);
                if (GUILayout.Button(EditorGUIUtility.ObjectContent(obj, obj.GetType()), GUI.skin.GetStyle("GUIEditor.BreadcrumbLeft")))
                {
                    Selection.activeInstanceID = instanceId;
                    this.currentIndex = instanceIdsIndex;
                    this.registerSelection = false;
                }
            }
        }
    }
}
