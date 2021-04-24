using UnityEngine;

// SceneControllerのスーパークラス
public class SceneControllerBase : SingletonMonoBehaviour<SceneControllerBase> {
  void Start() {
    _Start();
  }

  void Update() {
    _Update();
  }

  // サブクラスでオーバーライド
  public virtual void _Start(){}
  // サブクラスでオーバーライド
  public virtual void _Update(){}
}