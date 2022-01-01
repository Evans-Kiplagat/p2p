using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{

    [Header("UI Toolkit GameObjects")]
    [SerializeField] internal Login Login;
    [SerializeField] internal ScreenBase ActiveScreen;

    internal List<ScreenBase> _cameraMovementEnabledScreens;
    internal List<ScreenBase> _assetMouseClickEnabledScreens;
    private void Awake()
    {

        _cameraMovementEnabledScreens = new List<ScreenBase>()
        {
             Login,
        };
        _assetMouseClickEnabledScreens = new List<ScreenBase>()
        {
             Login
        };
    }
}
