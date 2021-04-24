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

  internal void StartScene(string sceneKey) {
    GameController.Instance.StartScene(sceneKey);
  }

}