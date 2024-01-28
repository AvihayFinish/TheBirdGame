using System.Collections;
using UnityEngine;

public class ConeSpawner : MonoBehaviour
{
    [SerializeField] float wait = 1f;
    [SerializeField] float minSize = 2f;
    [SerializeField] float maxSize = 4f;
    [SerializeField] float maxYDistance;
    
    [SerializeField] GameObject prefabToSpawn;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);

            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y  + Random.Range(-maxYDistance, +maxYDistance),
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);

            // Set the random size
            float theRandomSize = Random.Range(minSize, maxSize);
            Vector3 newScale = new Vector3(theRandomSize, theRandomSize, 1f);
            newObject.transform.localScale = newScale;
        }
    }

}