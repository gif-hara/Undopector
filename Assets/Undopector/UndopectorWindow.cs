using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UndopectorWindow : EditorWindow
{
    [MenuItem("Window/Undopector/Open")]
    private static void Open()
    {
        var window = CreateInstance<UndopectorWindow>();
        window.Show();
    }
}
