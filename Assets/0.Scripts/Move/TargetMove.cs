using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : Movement
{
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected override void Move()
    {
        if (player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, Speed * Time.deltaTime);
        }
    }
}