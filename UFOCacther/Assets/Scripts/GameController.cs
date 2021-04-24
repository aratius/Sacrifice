using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : SingletonMonoBehaviour<GameController>
{

    [SerializeField] GameSceneController gameSceneController;
    [SerializeField] ReceiveSceneController receiveSceneController;
    [SerializeField] PreviewSceneController previewSceneController;

    void Start()
    {

    }

    void Update()
    {

    }

    internal void StartScene(string sceneKey) {
        Debug.Log(sceneKey);
    }


    string HOME = "HOME";
    string GAME = "GAME";
    string RECEIVE = "RECEIVE";
    string PREVIEW = "PREVIEW";

}
