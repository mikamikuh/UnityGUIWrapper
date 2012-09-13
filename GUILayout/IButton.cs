using UnityEngine;
using System.Collections;

namespace UnityGUIWrapper
{

/// <summary>
/// Interface for wrapper class of Unity Button.
/// </summary>
public interface IButton
{
    /// <summary>
    /// Rendering this button from GUIContent, GUIStyle, GUILayoutOption infomation.
    /// Run click listener and double click listener if the button clicked.
    /// </summary>
    public void OnGUI();
}

}