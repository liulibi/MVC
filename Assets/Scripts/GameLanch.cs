using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLanch : UnitySingleton<GameLanch> {

    public override void Awake() {
        base.Awake();

        // ��ʼ����Ϸ���ģ��: ��Դ���������������������־����Э�����...
        this.gameObject.AddComponent<ResMgr>();
        // end

        this.gameObject.AddComponent<GameApp>();

    }

    void Start()
    {
        // �����Դ����
        // end

        GameApp.Instance.EnterGame();
    }

}
