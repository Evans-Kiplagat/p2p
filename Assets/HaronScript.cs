using Mirror.WebRTC;
using System;
using UnityEngine;

public class HaronScript : MonoBehaviour
{
    public string loginId;
    public RTCTransport rtcTransport;
    public string address;

    private RTCWebSocketSignaler rtcWebSocketSignaler;
    public RTCConnection rtcConnection;

    // Start is called before the first frame update
    void Start()
    {
        InitializeObject();
        ConnectToWebSocketSignaler();

        StartServer();
        //ConnectClientToServer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitializeObject()
    {
        //rtcTransport = GetComponent<RTCTransport>();
        //rtcWebSocketSignaler = (RTCWebSocketSignaler) rtcTransport.activeSignaler;

        rtcWebSocketSignaler = GetComponent<RTCWebSocketSignaler>();
        rtcTransport = GetComponent<RTCTransport>();
        //rtcTransport.activeSignaler = rtcWebSocketSignaler;

    }

    private void ConnectToWebSocketSignaler()
    {
        Debug.Log($"Attempting to connect as {loginId}");
        rtcWebSocketSignaler.Connect(loginId);
    }

    private void CloseWebSocketSignaler()
    {
        rtcWebSocketSignaler.Close();
    }

    private void StartServer()
    {
        rtcTransport.ServerStart();
    }

    private void ConnectClientToServer()
    {
        rtcTransport.ClientConnect(address);
    }
}