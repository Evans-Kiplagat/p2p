using System;
using System.Collections;
using System.Collections.Generic;
using Mirror.WebRTC;
using UnityEngine;
using UnityEngine.UIElements;


public class Login : ScreenBase
{

    /*
     * Connected Views
     */
    public ServerListView ServerListView; 

    /*
     * Child-Controls
     */

    private TextField _nameText;
    private Label     _connectingLabel;
    private Button    _loginButton;
    private Button    _evansButton;
    private Button    _haronButton;
    private Button    _corvinButton;
    private Button    _connectButton;

    /*
     * Fields, Properties
     */

    public RTCWebSocketSignaler rtcWebSocketSignaler;
    public RTCTransport rtcTransport;

    [HideInInspector]
    public string loginId;

    void Start()
    {
        _nameText = Root.Q<TextField>("name-input-field");
        _loginButton = Root.Q<Button>("login-id-button");
        _evansButton = Root.Q<Button>("evans-id-button");
        _haronButton = Root.Q<Button>("haron-id-button");
        _corvinButton = Root.Q<Button>("corvin-id-button");
        _connectButton = Root.Q<Button>("connect-button");
        _connectingLabel = Root.Q<Label>("welcome-label");

        _loginButton.clickable.clicked += async () =>
        {
            _connectingLabel.text = $"connecting as {loginId}";
            rtcWebSocketSignaler.Connect(loginId);
        };

        _haronButton.clickable.clicked += async () =>
        {
            _connectingLabel.text = "connecting... ";
            rtcWebSocketSignaler.Connect("haron-server");

            if (rtcWebSocketSignaler.connected)
            {
                _connectingLabel.text = $"connected as haron";
                _connectButton.Show();
            }
        };
        _corvinButton.clickable.clicked += async () =>
        {
            
            _connectingLabel.text = "connecting...";
            rtcWebSocketSignaler.Connect("corvin-server");

            if (rtcWebSocketSignaler.connected)
            {
                _connectingLabel.text = $"connected as corvin";
                _connectButton.Show();
            }
        };
        _evansButton.clickable.clicked += async () =>
        {
            _connectingLabel.text = "connecting...";
            rtcWebSocketSignaler.Connect("evans-server");

            if (rtcWebSocketSignaler.connected)
            {
                _connectingLabel.text = $"connected as evans";
                _connectButton.Show();
            }
        };
        

        _connectButton.clickable.clicked += () =>
        {
            this.Hide();

            //TODO Transition to ServerListView
            
        };

        SetLoginIdText();
        _connectButton.Hide();
    }

    private void SetLoginIdText()
    {
        _nameText.value = loginId;

        //_nameText.SetValueWithoutNotify(loginId);

        //if (_nameText.value != null)
        //{
        //    var isLoginIdRegistered = !string.IsNullOrEmpty(_nameText.value.ToLower());
        //    if (isLoginIdRegistered)
        //    {
        //        //if true login to the view

        //    }
        //    else
        //    {
               
        //    }

        //}
    }
}
