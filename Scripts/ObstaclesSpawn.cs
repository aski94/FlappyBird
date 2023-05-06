using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstaclesSpawn : MonoBehaviour
{
    public GameObject Obstacle;
    public float spawnRate = 3f;
    public float minY = -3f;
    public float maxY = 2f;
    private GameObject instantiatedObstacle;

    void Start()
    {
        InvokeRepeating("obstacleSpawn", 0f, spawnRate);
    }

    void obstacleSpawn()
    {
        instantiatedObstacle = Instantiate(Obstacle, new Vector2(14, Random.Range(minY,maxY)), Quaternion.identity);
        Destroy(instantiatedObstacle, 15f);
    }
   
}
