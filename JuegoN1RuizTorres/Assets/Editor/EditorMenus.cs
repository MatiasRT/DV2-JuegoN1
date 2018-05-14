﻿using UnityEditor;

static class EditorMenus
{
    // taken from: http://answers.unity3d.com/questions/282959/set-inspector-lock-by-code.html
    [MenuItem("Tools/Toggle Inspector Lock #q")] // Ctrl + L = %l
    static void ToggleInspectorLock()
    {
        ActiveEditorTracker.sharedTracker.isLocked = !ActiveEditorTracker.sharedTracker.isLocked;
        ActiveEditorTracker.sharedTracker.ForceRebuild();
    }
}
