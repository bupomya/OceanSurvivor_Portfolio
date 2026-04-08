using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 스테이지 배치, 공 속도 조절 등등을 관리함
// 일정 시간 후에 공 속도 복구
// 복구 후 Play 상태로 변환

public class StartState : StageState
{
    public override void EnterState(StageFSMController.STATE state)
    {
        base.EnterState(state);

        stageManager.SetStage(); // 스테이지 배치
        // 공속도 조절
        // 게임 시작 UI 표시
    }

    public override void UpdateState()
    {
         //스테이지 넘어가는 조건
         // 코루틴으로 UI 표시 시간을 주고 넘어가는 조건문
    }


    public override void ExitState()
    {
        // 게임시작시 표시되는 UI제거
    }

}
