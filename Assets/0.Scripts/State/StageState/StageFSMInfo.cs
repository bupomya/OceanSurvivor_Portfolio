using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageFSMInfo : MonoBehaviour
{
    [Header("화면 관련")]

    [SerializeField] float pageDuration; // 페이지 넘어가는 시간

    [Header("공 관련")]

    [SerializeField] float curBallSpeed; // 현재 공 속도
    [SerializeField] float slowBallSpeed; // 게임시작시 느려지는 공속도
    [SerializeField] float itemBallSpeed; // 아이템 또는 상점에서 구매한 공 속도
    
    [SerializeField] float curBallDamage; //현재 공 데미지
    [SerializeField] float basicBallDamage; // 기본 공 데미지
    [SerializeField] float itemBallDamage; // 아이템 또는 상점에서 구매한 공 데미지

    [Header("플레이어 관련")]

    [SerializeField] float curPlayerSpeed; // 현재 플레이어 속도
    [SerializeField] float slowPlayerSpeed; // 게임시작시 느려지는 플레이어 속도 (이건 필요없을지도)
    [SerializeField] float itemPlayerSpeed; // 아이템 또는 상점에서 구매한 플레이어 속도



    public float PageDuration { get => pageDuration; set => pageDuration = value; }
    public float CurBallSpeed { get => curBallSpeed; set => curBallSpeed = value; }
    public float SlowBallSpeed { get => slowBallSpeed; set => slowBallSpeed = value; }
    public float ItemBallSpeed { get => itemBallSpeed; set => itemBallSpeed = value; }
    public float CurBallDamage { get => curBallDamage; set => curBallDamage = value; }
    public float BasicBallDamage { get => basicBallDamage; set => basicBallDamage = value; }
    public float ItemBallDamage { get => itemBallDamage; set => itemBallDamage = value; }
    public float CurPlayerSpeed { get => curPlayerSpeed; set => curPlayerSpeed = value; }
    public float SlowPlayerSpeed { get => slowPlayerSpeed; set => slowPlayerSpeed = value; }
    public float ItemPlayerSpeed { get => itemPlayerSpeed; set => itemPlayerSpeed = value; }
}
