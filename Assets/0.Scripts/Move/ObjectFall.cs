using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : MonoBehaviour
{
    [SerializeField] private float fallDelay;

    [SerializeField] private float gravityScale;

    private Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        StartCoroutine(ObjectFalling());
    }

    private IEnumerator ObjectFalling()
    {
        yield return new WaitForSeconds(fallDelay);

        rb2d.gravityScale = gravityScale;
    }

}
