using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

public class UndopectorWindow : EditorWindow
{
    private static UndopectorWindow instance;

    [SerializeField]
    private Texture undoImage;

    [SerializeField]
    private Texture redoImage;

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
            if (GUILayout.Button(this.undoImage, ButtonGUILayoutOptions))
            {
                this.registerSelection = false;
                this.currentIndex--;
                Selection.activeInstanceID = this.instanceIds[this.currentIndex];
            }
            EditorGUI.EndDisabledGroup();

            EditorGUI.BeginDisabledGroup(this.currentIndex >= this.instanceIds.Count - 1);
            if (GUILayout.Button(this.redoImage, ButtonGUILayoutOptions))
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

    private void DrawChangeSelectionButton(int instanceIdsIndex)
    {
        var instanceId = this.instanceIds[instanceIdsIndex];

        EditorGUI.BeginDisabledGroup(this.currentIndex == instanceIdsIndex);
        var obj = EditorUtility.InstanceIDToObject(instanceId);
        if (GUILayout.Button(EditorGUIUtility.ObjectContent(obj, obj.GetType()), GUI.skin.GetStyle("GUIEditor.BreadcrumbLeft")))
        {
            Selection.activeInstanceID = instanceId;
            this.currentIndex = instanceIdsIndex;
            this.registerSelection = false;
        }
        EditorGUI.EndDisabledGroup();
    }
}
