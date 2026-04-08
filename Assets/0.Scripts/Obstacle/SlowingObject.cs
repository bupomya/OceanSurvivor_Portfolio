using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingObject : MonoBehaviour
{
    private Transform objectTransform;

    [SerializeField] private float hitCount = 6;
    [SerializeField] private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        objectTransform = transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball") && hitCount > 0)
        {
            audioSource.Play();
            hitCount--;
            objectTransform.localScale *= 1.3f;
            Debug.Log("Ãæµ¹");
        }
        //else if (collision.CompareTag("Player"))
        //{
            //playerMove = collision.GetComponent<>();
            //if (playerMove != null)
            //{
            //    PlayerSpeed Down
            //}
        //}
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        defaultspeed
    //    }
    //}
}