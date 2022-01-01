using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class ScreenBase : MonoBehaviour
{
    internal bool IsScreenVisible;

    internal UIDocument Screen;
    internal VisualElement Root;

    internal event Action OnShow;
    internal event Action OnHide;

    void Awake()
    {
        Screen = GetComponent<UIDocument>();
        Root = Screen.rootVisualElement;

        Hide();
    }

    public void Show()
    {
        //Root.Show();
        OnShow?.Invoke();
        IsScreenVisible = true;
    }

    public void Hide()
    {
        //Root.Hide();
        OnHide?.Invoke();
        IsScreenVisible = false;
    }

   
}