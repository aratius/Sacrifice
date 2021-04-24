using UnityEngine.Events;

public class ActionRouter {

  static ActionRouter actionRouter = new ActionRouter();

  public static ActionRouter Instance {
    get {
      return actionRouter;
    }
  }

  // シングルトンのコンストラクタ
  private ActionRouter (){
  }

  internal void SubmitEvents(
    UnityAction homeEv,
    UnityAction gameEv,
    UnityAction receiveEv,
    UnityAction previewEv
  ) {
    GameController.Instance.onHomeEv.AddListener(homeEv);
    GameController.Instance.onGameEv.AddListener(gameEv);
    GameController.Instance.onReceiveEv.AddListener(receiveEv);
    GameController.Instance.onPreviewEv.AddListener(previewEv);
  }

  internal void StartScene(string sceneKey) {
    GameController.Instance.StartScene(sceneKey);
  }

  internal void EndScene() {
    GameController.Instance.EndScene();
  }

}