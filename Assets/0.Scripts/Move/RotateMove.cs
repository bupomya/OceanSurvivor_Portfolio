using UnityEngine;

public class RotateMove : AllDirectionMove
{
    [SerializeField] private float rotateSpeed; 

    [SerializeField] private float maxXpos;     
    [SerializeField] private float minXpos; 

    private bool isMoving = true;        

    public bool IsMoving { get => isMoving; set => isMoving = value; }

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MoveDir = IsRight ? Vector2.right : Vector2.left;
    }

    protected override void Move()
    {
        if (!isMoving) return;

        rb.MovePosition(rb.position + MoveDir * Speed * Time.deltaTime);

        float rotation = transform.eulerAngles.z + rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}