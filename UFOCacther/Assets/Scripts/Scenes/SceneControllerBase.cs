using UnityEngine;

// SceneControllerのスーパークラス
public class SceneControllerBase : SingletonMonoBehaviour<SceneControllerBase> {
  void Start() {
    _Start();
  }

  void Update() {
    _Update();
  }

  void StartScene() {
    _StartScene();
  }

  void EndScene() {
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