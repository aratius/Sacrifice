using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    public SerialHandler serialHandler;
    void Start()
    {
        // serialHandlerのØnDataReceivedに反応してこっちのも処理する
        serialHandler.OnDataReceived += OnDataReceived;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDataReceived(string message) {
        var data = message.Split(
            new string[]{"\t"}, System.StringSplitOptions.None);
        if(data.Length < 2) return;

        try {
            for(int i = 0; i < data.Length; i++) {
                Debug.Log(data[i]);
            }
        }catch (System.Exception e) {
            Debug.LogWarning(e.Message);
        }
    }
}