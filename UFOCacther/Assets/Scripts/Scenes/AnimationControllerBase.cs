using UnityEngine;

// SceneControllerのスーパークラス
public class AnimationControllerBase : SingletonMonoBehaviour<AnimationControllerBase> {
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