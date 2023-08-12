using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewArea : MonoBehaviour
{
    [SerializeField] GameObject BackStageArea;
    [SerializeField] GameObject points;
    
    [SerializeField] GameObject obstacles;
    Vector3 positionBackStageArea, pointSpawnPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tags.playerBall)
        {
            positionBackStageArea = BackStageArea.transform.position;
            Quaternion rotation = BackStageArea.transform.rotation;
            positionBackStageArea.x += 20;
            Instantiate(BackStageArea, positionBackStageArea, rotation);
            SpawnNewObject(points);
            SpawnNewObject(obstacles);
        }
    }
    private void SpawnNewObject(GameObject objectForSpawn)
    {
        
        int countSpawnPoints = Random.Range(1, 3);
        if (countSpawnPoints == 1)
        {
            pointSpawnPosition = SetPositionForSpawnPoint(positionBackStageArea);
            Instantiate(objectForSpawn, pointSpawnPosition, Quaternion.identity);
        }
        else
        {
            for(int i = 0; i < countSpawnPoints; i++)
            {
                pointSpawnPosition = SetPositionForSpawnPoint(positionBackStageArea);
                Instantiate(objectForSpawn, pointSpawnPosition, Quaternion.identity);
            }

        }


    }
    private Vector3 SetPositionForSpawnPoint(Vector3 startPosition)
    {
        Vector3 positionSpawnPoints = startPosition;
        float x = 10, y = 5;
        positionSpawnPoints.x += x + Random.Range(-2f, 2f);
        positionSpawnPoints.y += y + Random.Range(-5f, 5f);
        return positionSpawnPoints;

    }
}
