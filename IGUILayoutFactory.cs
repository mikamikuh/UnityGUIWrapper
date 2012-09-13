using UnityEngine;
using System.Collections;

/// <summary>
/// Provide create methods of Unity GUI wrapper classes.
/// </summary>
public interface IGUILayoutFactory : MonoBehaviour
{
    /// <summary>
    /// Create GUILayout.Button wrapper class.
    /// </summary>
    /// <return>
    /// Instance of UnityGUIWrapper.Button.
    /// </return>
    public Button createButton()
}
