using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스테이지 실패시 들어오는 상태
// 그에 맞는 UI 또는 코드 구현
// ExitState 에서 Start 상태로 돌아가 현재 스테이지를 다시 배치하게

public class FailState : StageState
{
    public override void EnterState(StageFSMController.STATE state)
    {
        base.EnterState(state);

        //실패 UI 표시

    }

    public override void UpdateState()
    {
        // 시작 상태 조건
        // 스페이스바 또는 아무키 누를시 현재 스테이지 재시작
    }


    public override void ExitState()
    {
        //실패 UI 종료
    }

}
