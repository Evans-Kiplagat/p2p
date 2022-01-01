using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable()]
public class Control : MonoBehaviour
{
    /// <summary>
    /// The UXML file to render
    /// </summary>
    public VisualTreeAsset uxml;

    /// <summary>
    /// The main style sheet file to give styles to Unity provided elements
    /// </summary>
    public StyleSheet unityStyleSheet;
    // Start is called before the first frame update

    public VisualElement Clone()
    {
        var element = new VisualElement();

        uxml.CloneTree(element);
        element.styleSheets.Add(unityStyleSheet);

        return element;
    }
}
