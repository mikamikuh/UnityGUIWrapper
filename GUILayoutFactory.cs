using System.Collections;

namespace UnityGUIWrapper
{

/// <summary>
/// Provide create methods of Unity GUI wrapper classes.
/// </summary>
public class GUILayoutFactory : IGUILayoutFactory
{
    /// <summary>
    /// Return singleton instance.
    /// </summary>
    public static GUILayoutFactory INSTANCE = new GUILayoutFactory();

    /// <summary>
    /// The class is singleton.
    /// </summary>
    private GUILayoutFactory()
    {
    }

    /// <summary>
    /// Create GUILayout.Button wrapper class.
    /// </summary>
    /// <return>
    /// Instance of UnityGUIWrapper.Button.
    /// </return>
    public Button createButton()
    {
        return new Button();
    }
}
}