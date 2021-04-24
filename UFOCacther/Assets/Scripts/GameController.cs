using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameController : SingletonMonoBehaviour<GameController>
{
    [SerializeField] HomeSceneController homeSceneController;
    [SerializeField] GameSceneController gameSceneController;
    [SerializeField] ReceiveSceneController receiveSceneController;
    [SerializeField] PreviewSceneController previewSceneController;

    internal UnityEvent HomeEv = new UnityEvent();
    internal UnityEvent GameEv = new UnityEvent();
    internal UnityEvent ReceiveEv = new UnityEvent();
    internal UnityEvent PreviewEv = new UnityEvent();

    void Start()
    {
        homeSceneController.transitionSampleEvent.AddListener(()=>GameEv.Invoke());
    }

    void Update()
    {

    }

    internal void StartScene(string sceneKey) {
        if(sceneKey != CURRENT_SCENE_KEY) {
            CURRENT_SCENE_KEY = sceneKey;

            if(CURRENT_SCENE_KEY == HOME) {
                homeSceneController.StartScene();
            }else if(CURRENT_SCENE_KEY == GAME) {
                gameSceneController.StartScene();
            }else if(CURRENT_SCENE_KEY == RECEIVE) {
                receiveSceneController.StartScene();
            }else if(CURRENT_SCENE_KEY == PREVIEW) {
                previewSceneController.StartScene();
            }
        }
    }

    internal void EndScene() {
        if(CURRENT_SCENE_KEY == HOME) {
            homeSceneController.EndScene();
        }else if(CURRENT_SCENE_KEY == GAME) {
            gameSceneController.EndScene();
        }else if(CURRENT_SCENE_KEY == RECEIVE) {
            receiveSceneController.EndScene();
        }else if(CURRENT_SCENE_KEY == PREVIEW) {
            previewSceneController.EndScene();
        }
    }

    internal void SubmitEvents() {

    }


    string HOME = "HOME";
    string GAME = "GAME";
    string RECEIVE = "RECEIVE";
    string PREVIEW = "PREVIEW";
    string CURRENT_SCENE_KEY = "";

}
