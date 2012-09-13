using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace UnityGUIWrapper
{

/// <summary>
/// Wrapper class of GUILayout.Button in Unity.
/// Provide functions of holding click listeners and information for rendering.
/// </summary>
public class Button : IButton
{
    private IList<Action> clickListeners;

    /// <summary>
    /// When this button is single clicked, the listeners run.
    /// </summary>
    public IList<Action> ClickListeners
    {
        get
        {
            return clickListeners;
        }
    }

    private IList<Action> doubleClickListeners;

    /// <summary>
    /// When this button is single clicked, the listeners run.
    /// </summary>
    public IList<Action> DoubleClickListeners
    {
        get
        {
            return doubleClickListeners;
        }

    }

    private UnityEngine.GUILayoutOption[] guiLayoutOptions;

    /// <summary>
    /// The variable is used when rendering this button.
    /// If you don't set the variable, it use as empty array.
    /// </summary>
    public UnityEngine.GUILayoutOption[] GUILayoutOption
    {
        get
        {
            return guiLayoutOptions;
        }

        set
        {
            guiLayoutOptions = value;
        }
    }

    private UnityEngine.GUIContent guiContent;

    /// <summary>
    /// The variable has rendering information like label and image.
    /// Please make the instance and put information of label or image.
    /// </summary>
    public UnityEngine.GUIContent GUIContent
    {
        get
        {
            return guiContent;
        }
        set
        {
            guiContent = value;
        }
    }

    private UnityEngine.GUIStyle guiStyle;

    /// <summary>
    /// The variable is used when this button rendering.
    /// If you don't set the variable, it is used GUIStyle.None.
    /// </summary>
    public UnityEngine.GUIStyle GUIStyle
    {
        get
        {
            return guiStyle;
        }
        set
        {
            guiStyle = value;
        }
    }

    /// <summary>
    /// Create new instance of wrapper class of Button.
    /// You should make the instance from GUILayoutFactory basically.
    /// </summary>
    public Button()
    {
        clickListeners = new List<Action>();
        doubleClickListeners = new List<Action>();
        guiContent = GUIContent.none;
        guiStyle = GUIStyle.none;
        guiLayoutOptions = new UnityEngine.GUILayoutOption[0];

    }

    /// <summary>
    /// Rendering this button from GUIContent, GUIStyle, GUILayoutOption infomation.
    /// Run click listener and double click listener if the button clicked.
    /// </summary>
    public void OnGUI()
    {
        if (GUILayout.Button(guiContent, guiStyle, guiLayoutOptions) == false)
        {
            return;
        }

        if (Event.current.clickCount == 1)
        {
            // Run single click listeners
            foreach (Action f in clickListeners)
            {
                f();
            }
        }
        else
        {
            // Run double click listeners
            foreach (Action f in doubleClickListeners)
            {
                f();
            }
        }
    }
}

}