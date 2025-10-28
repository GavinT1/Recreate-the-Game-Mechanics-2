using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject[] spawnObjects; 
    public float spawnInterval = 2f;  
    public Vector2 spawnYRange = new Vector2(-3f, 3f); 
    public float spawnX = -10f;
    public float moveSpeed = 3f; 
    public float destroyX = 10f; 

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 1f, spawnInterval);
    }

    void SpawnObject()
    {
        if (spawnObjects.Length == 0) return;

        
        GameObject prefab = spawnObjects[Random.Range(0, spawnObjects.Length)];

        
        float randomY = Random.Range(spawnYRange.x, spawnYRange.y);
        Vector3 spawnPos = new Vector3(spawnX, randomY, 0);

        
        GameObject newObj = Instantiate(prefab, spawnPos, Quaternion.identity);

        
        MovingObject mover = newObj.AddComponent<MovingObject>();
        mover.speed = moveSpeed;
        mover.destroyX = destroyX;
    }
}