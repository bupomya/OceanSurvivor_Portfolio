using UnityEngine;

public class WaypointMover : Movement
{
    [SerializeField] private Vector3[] wayPositions;
    [SerializeField] private GameObject[] gameObjects;
    private int[] currentWaypointIndexes; 
    private bool movingForward = true;

    protected override void Move()
    {
        if (wayPositions.Length > 0)
        {
            if (currentWaypointIndexes == null || currentWaypointIndexes.Length != gameObjects.Length)
            {
                currentWaypointIndexes = new int[gameObjects.Length];
                for (int i = 0; i < gameObjects.Length; i++)
                {
                    currentWaypointIndexes[i] = 0; 
                }
            }

            for (int i = 0; i < gameObjects.Length; i++)
            {
                GameObject obj = gameObjects[i];

                obj.transform.position = Vector3.MoveTowards(obj.transform.position, wayPositions[currentWaypointIndexes[i]], Speed * Time.deltaTime);

                if (obj.transform.position == wayPositions[currentWaypointIndexes[i]])
                {
                    if (movingForward)
                    {
                        currentWaypointIndexes[i]++;
                        if (currentWaypointIndexes[i] >= wayPositions.Length)
                        {
                            currentWaypointIndexes[i] = wayPositions.Length - 1;
                        }
                    }
                    else
                    {
                        currentWaypointIndexes[i]--;
                        if (currentWaypointIndexes[i] < 0)
                        {
                            currentWaypointIndexes[i] = 0;
                        }
                    }
                }
            }

            if (currentWaypointIndexes[0] >= wayPositions.Length - 1 || currentWaypointIndexes[0] < 0)
            {
                movingForward = !movingForward;
            }
        }
    }
}