using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApp : UnitySingleton<GameApp>
{
    // 游戏逻辑的总入口;
    public void EnterGame() {
        Debug.Log("Enter Game!");
        this.EnterGameScene();
    }

    private void EnterGameScene() {
        // 释放游戏地图内容
        // end

        // 释放角色，NPC，物品
        // end

        // 释放我们的UI
        UIMgr.Instance.ShowUIView("UIMainCity");
        // end
    }

}
