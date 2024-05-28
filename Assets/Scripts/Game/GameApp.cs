using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApp : UnitySingleton<GameApp>
{
    // ��Ϸ�߼��������;
    public void EnterGame() {
        Debug.Log("Enter Game!");
        this.EnterGameScene();
    }

    private void EnterGameScene() {
        // �ͷ���Ϸ��ͼ����
        // end

        // �ͷŽ�ɫ��NPC����Ʒ
        // end

        // �ͷ����ǵ�UI
        UIMgr.Instance.ShowUIView("UIMainCity");
        // end
    }

}
