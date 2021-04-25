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

    internal UnityEvent onHomeEv = new UnityEvent();
    void onHome(){onHomeEv.Invoke();}
    internal UnityEvent onGameEv = new UnityEvent();
    void onGame(){onGameEv.Invoke();}
    internal UnityEvent onReceiveEv = new UnityEvent();
    void onReceive(){onReceiveEv.Invoke();}
    internal UnityEvent onPreviewEv = new UnityEvent();
    void onPreview(){onPreviewEv.Invoke();}

    void Start()
    {
    }

    void Update()
    {

    }

    internal void StartScene(string sceneKey) {
        // 一通りイベントの登録
        homeSceneController.transitionSampleEvent.AddListener(onGame);
        // gameSceneController.transitionSampleEvent.AddListener(onReceive);
        // receiveSceneController.transitionSampleEvent.AddListener(onPreview);
        // previewSceneController.transitionSampleEvent.AddListener(onHome);

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

        // 一通りイベントの解除
        homeSceneController.transitionSampleEvent.RemoveListener(onHome);
        gameSceneController.transitionSampleEvent.RemoveListener(onReceive);
        receiveSceneController.transitionSampleEvent.RemoveListener(onPreview);
        // previewSceneController.transitionSampleEvent.RemoveListener(onHome);
    }

    internal void SubmitEvents() {

    }


    string HOME = "HOME";
    string GAME = "GAME";
    string RECEIVE = "RECEIVE";
    string PREVIEW = "PREVIEW";
    string CURRENT_SCENE_KEY = "";

}
