using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 모든 상태를 여기선 관리하고
// Update는 여기서만 돌아가므로 각 상태가 충돌나는 경우를 막음
public class StageFSMController : MonoBehaviour
{
    public enum STATE { START, PLAY, CLEAR, FAIL }

    [SerializeField] private StageState currentState;

    [SerializeField] private StageState[] stageStates;

    private void Start()
    {
        TransactionToState(STATE.START);
    }

    private void Update()
    {
        currentState?.UpdateState();
    }

    public void TransactionToState(STATE state)
    {
        currentState?.ExitState(); //이전 상태 정리
        currentState = stageStates[(int)state];
        currentState.EnterState(state);
    }
}
