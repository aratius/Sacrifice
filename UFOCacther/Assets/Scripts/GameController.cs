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
}
