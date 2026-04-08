using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPositions;
    [SerializeField] private GameObject fallingObjectPrefab;
    [SerializeField] private int maxActiveFallingObjects = 2;

    private Queue<Transform> availableSpawnPositions = new Queue<Transform>();
    private HashSet<GameObject> activeFallingObjects = new HashSet<GameObject>();

    void Start()
    {
        foreach (Transform position in spawnPositions)
        {
            availableSpawnPositions.Enqueue(position);
        }
    }

    void Update()
    {
        if (activeFallingObjects.Count < maxActiveFallingObjects && availableSpawnPositions.Count > 0)
        {
            SpawnFallingObject();
        }
    }

    void SpawnFallingObject()
    {
        if (availableSpawnPositions.Count == 0) return;

        Transform spawnPosition = availableSpawnPositions.Dequeue();
        GameObject newFallingObject = Instantiate(fallingObjectPrefab, spawnPosition.position, Quaternion.identity);
        activeFallingObjects.Add(newFallingObject);

        float lifetime = Random.Range(5f, 10f);
        StartCoroutine(DestroyFallingObject(newFallingObject, spawnPosition, lifetime));
    }

    IEnumerator DestroyFallingObject(GameObject fallingObject, Transform spawnPosition, float delay)
    {
        yield return new WaitForSeconds(delay);

        if (fallingObject != null)
        {
            activeFallingObjects.Remove(fallingObject);
            Destroy(fallingObject);
            availableSpawnPositions.Enqueue(spawnPosition);  
        }
    }
}