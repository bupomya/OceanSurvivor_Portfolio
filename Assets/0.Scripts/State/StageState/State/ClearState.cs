using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//클리어 UI나 코드 구현 하는곳

//Exit로 빠져나갈때 스테이지를 바꾸고 다시 Start 상태로 바꿔 해당 스테이지를 다시 배치하고 넘어가게
// ex) curStage ++
public class ClearState : StageState
{
    public override void EnterState(StageFSMController.STATE state)
    {
        base.EnterState(state);
        stageManager.NextStage(); // 스테이지 index 증가
        //스테이지 클리어 UI 표시

    }

    public override void UpdateState()
    {
       //시작상태 조건
    }


    public override void ExitState()
    {
        // 스테이지 클리어 UI 종료
    }

}
