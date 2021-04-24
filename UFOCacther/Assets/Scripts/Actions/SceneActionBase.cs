using UnityEngine;
using System;

namespace HutongGames.PlayMaker.Actions {
    [ActionCategory("Custom Category")]  // カテゴリの指定
    [Tooltip("全てのアクションの親クラス こいつを直接使うことはない")]  // ToolTipとは？ 説明文的なこと？

    public class SceneActionBase : FsmStateAction {

        protected ActionRouter controller;

        [Tooltip("ControllerGameObject")]
        public GameObject gameObject;

        [RequiredField]
        public bool deleteOnExit = true;  //active状態をいじるかどうか activateOnEnterみたいな

        public void Reset() {
            gameObject = null;
        }

        public override void OnEnter() {
            BeforeOnEnter();

            controller = ActionRouter.Instance;

            if(gameObject != null) {
                gameObject.SetActive(true);
            }

            AfterOnEnter();
            Finish();
        }

        public virtual void BeforeOnEnter() {}
        public virtual void AfterOnEnter() {}

        public override void OnExit(){
            BeforeOnExit();

            if(deleteOnExit) {
                if(gameObject != null) {
                    gameObject.SetActive(false);
                }
            }

            AfterOnExit();
        }

        public virtual void BeforeOnExit() {}
        public virtual void AfterOnExit() {}

        // ----------------------------------
        // 子クラスでオーバーライドするメイン処理
        // ----------------------------------
        public virtual void DoAction() {}

    }
}