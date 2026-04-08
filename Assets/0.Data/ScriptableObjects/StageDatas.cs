using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "StageData", menuName = "Game/Stage Data")]
public class StageDatas : ScriptableObject
{
    //스테이지 번호
    [SerializeField] private int stageNum;

    //스테이지별 오브젝트
    [SerializeField] private List<GameObject> stageObejcts;

    //스테이지별 배경
    [SerializeField] private GameObject background;

    public List<GameObject> StageObejcts { get => stageObejcts; set => stageObejcts = value; }

    [Serializable]
    public class MonsterData
    {
        public Vector2 position; // 스폰 위치
    }
}
