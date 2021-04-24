
namespace HutongGames.PlayMaker.Actions {
  [ActionCategory("Custom Category")]  // カテゴリの指定
  [Tooltip("シーンのアクション")]  // ToolTipとは？ 説明文的なこと？

  public class SceneAction : SceneActionBase {

    [RequiredField]
    [UIHint(UIHint.Variable)]
    public FsmString sceneKey;

    public override void AfterOnEnter()
    {
      controller.StartScene(sceneKey.Value);
    }

    public override void BeforeOnExit()
    {
      controller.EndScene();
    }

  }

}