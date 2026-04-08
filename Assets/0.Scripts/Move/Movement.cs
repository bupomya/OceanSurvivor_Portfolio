using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Vector2 moveDir;

    [SerializeField] private bool isRight;

    
    public float Speed { get => speed; set => speed = value; }
    public Vector2 MoveDir { get => moveDir; set => moveDir = value; }

    public bool IsRight { get => isRight; set => isRight = value; }

    protected abstract void Move();

    private void Update()
    {
        Move();
    }
}
