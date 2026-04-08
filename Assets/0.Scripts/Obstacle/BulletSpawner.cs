using System.Collections;
using UnityEngine;
public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform[] ballSpawnPositions;
    [SerializeField] protected float shotDelay;

    private bool canShoot = true;
    private RotateMove rotatingMover;

    private void Start()
    {
        rotatingMover = GetComponentInParent<RotateMove>();
    }

    private void Update()
    {
        if (!rotatingMover.IsMoving && canShoot)
        {
            BallSpawn();
            canShoot = false;
            StartCoroutine(ReloadShot());
        }
    }

    private void BallSpawn()
    {
        foreach (Transform spawnPos in ballSpawnPositions)
        {
            Instantiate(ballPrefab, spawnPos.position, spawnPos.rotation);
        }
    }

    private IEnumerator ReloadShot()
    {
        yield return new WaitForSeconds(shotDelay);
        canShoot = true;
    }
}