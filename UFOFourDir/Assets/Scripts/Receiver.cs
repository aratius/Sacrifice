using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{

    [SerializeField] Catcher catcher;

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
            catcher.GetParemeter(data);
            for(int i = 0; i < data.Length; i++) {
                // Debug.Log(data[i]);
            }
        }catch (System.Exception e) {
            Debug.Log("undefined err");
            Debug.LogWarning(e.Message);
        }
    }
}