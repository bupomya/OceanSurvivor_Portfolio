using System.Collections;
using UnityEngine;

public class BubbleObject : MonoBehaviour
{
    [SerializeField] private float reSpawnTime = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            //Ball ball = collision.GetComponent<Ball>();
            //ball.MoveDir = new Vector2(-ball.MoveDir.x, -ball.MoveDir.y).normalized;

            StartCoroutine(HideObject());
        }
    }

    private IEnumerator HideObject()
    {
        gameObject.SetActive(false);
        yield return new WaitForSeconds(reSpawnTime);
        gameObject.SetActive(true);
    }

}