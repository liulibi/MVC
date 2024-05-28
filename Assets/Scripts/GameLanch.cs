using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLanch : UnitySingleton<GameLanch> {

    public override void Awake() {
        base.Awake();

        // 初始化游戏框架模块: 资源管理，声音管理，网络管理，日志管理，协议管理...
        this.gameObject.AddComponent<ResMgr>();
        // end

        this.gameObject.AddComponent<GameApp>();

    }

    void Start()
    {
        // 检查资源更新
        // end

        GameApp.Instance.EnterGame();
    }

}
