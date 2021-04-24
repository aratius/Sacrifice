
namespace HutongGames.PlayMaker.Actions {
  [ActionCategory("Custom Category")]  // カテゴリの指定
  [Tooltip("シーンのアクション")]  // ToolTipとは？ 説明文的なこと？

  public class SubmitEventsAction : SceneActionBase {

    [RequiredField]
    [UIHint(UIHint.Variable)]
    public FsmString HOME;
    [RequiredField]
    [UIHint(UIHint.Variable)]
    public FsmString GAME;
    [RequiredField]
    [UIHint(UIHint.Variable)]
    public FsmString RECEIVE;
    [RequiredField]
    [UIHint(UIHint.Variable)]
    public FsmString PREVIEW;

    public override void AfterOnEnter()
    {
      controller.SubmitEvents(
        () => DoFsmEvent(HOME.Value),
        () => DoFsmEvent(GAME.Value),
        () => DoFsmEvent(RECEIVE.Value),
        () => DoFsmEvent(PREVIEW.Value)
      );
    }

    public override void BeforeOnExit()
    {
      // controller.EndScene();
    }

    void DoFsmEvent(string eventKey) {
      Fsm.Event(eventKey);
    }

  }

}