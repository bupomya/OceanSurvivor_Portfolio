using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    [SerializeField] private int maxHp;

    [SerializeField] private int curHp;

    [SerializeField] private bool isDead;
    public bool IsDead { get => isDead; set => isDead = value; }

    //피격 애니메이션(파티클)이 여기 들어가는게 좋을거같은데

    private void Start()
    {
        curHp = maxHp;
    }

    protected virtual void Hit(int damage)
    {
        curHp -= damage;
        curHp = Mathf.Clamp(curHp, 0, maxHp);

        if(curHp <= 0)
        {
            isDead = true;
        }
    }
}
