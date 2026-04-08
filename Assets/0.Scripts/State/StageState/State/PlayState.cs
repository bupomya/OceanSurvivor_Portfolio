using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이 중 필요한 코드 작성
//플레이 하는 도중 특정 상호작용을 막는 등등

public class PlayState : StageState
{
    public override void EnterState(StageFSMController.STATE state)
    {
        base.EnterState(state);
        //공 속도 완성복구

    }

    public override void UpdateState()
    {
        //스테이지 클리어 조건

        //스테이지 실패 조건
    }


    public override void ExitState()
    {
        //플레이 상태에서 종료할 메소드 실행

        //배치된 오브젝트들 제거
    }

}
