using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDirectionMove : Movement
{
    protected override void Move()
    {
        transform.Translate(MoveDir * Speed * Time.deltaTime);
    }
}