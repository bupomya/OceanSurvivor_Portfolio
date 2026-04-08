using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StageState : MonoBehaviour
{
    protected StageManager stageManager;

    protected StageFSMController controller;

    protected StageFSMInfo stageFsmInfo;



    protected void Awake()
    {
        controller = GetComponent<StageFSMController>();
        stageFsmInfo = GetComponent<StageFSMInfo>();
        stageManager = FindAnyObjectByType<StageManager>();
    }

    public virtual void EnterState(StageFSMController.STATE state)
    {
        Debug.Log($"{state} ป๓ลย");
    }

    public abstract void UpdateState();

    public abstract void ExitState();
}
