using UnityEngine;
using UnityEngine.Events;

// SceneControllerのスーパークラス
public class SceneControllerBase : SingletonMonoBehaviour<SceneControllerBase> {

  internal UnityEvent transitionSampleEvent = new UnityEvent();

  void Start() {
    _Start();
  }

  void Update() {
    _Update();
  }

  internal void StartScene() {
    transitionSampleEvent.Invoke();
    _StartScene();
  }

  internal void EndScene() {
    Debug.Log("end scene");
    _EndScene();
  }

  // サブクラスでオーバーライド
  public virtual void _Start(){}
  // サブクラスでオーバーライド
  public virtual void _Update(){}
  // サブクラスでオーバーライド
  public virtual void _StartScene(){}
  // サブクラスでオーバーライド
  public virtual void _EndScene(){}

}