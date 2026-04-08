using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "stageList", menuName = "stage/StageList")]
public class StageList : ScriptableObject
{
    //스테이지 데이터를 담은 List
    //Dictionary로 하는게 나은가?
    [SerializeField] private List<StageDatas> list;

    public List<StageDatas> List { get => list; set => list = value; }
}
