using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    //public float spawnRate = 1.5f;
    //private float screenLeft;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 2f;
    private float screenRight;
    private float screenBottom;
    private float screenTop;
    private Coroutine spawnCoroutine; 
    //public float spawnRate = 1f;
    //public float minHeight = -1f;
    //public float maxHeight = 2f;
    //public float verticalGap = 3f;

    private void Start()
    {
        Camera cam = Camera.main;
        //screenLeft = cam.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 2f;
        screenRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x + 2f;
        screenBottom = cam.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
        screenTop = cam.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;

        //InvokeRepeating(nameof(SpawnRoutine), 0f, spawnRate);

    }
    private void OnEnable()
    {
        //InvokeRepeating(nameof(SpawnRoutine), spawnRate, spawnRate);
        spawnCoroutine = StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        //CancelInvoke(nameof(SpawnRoutine));
        if (spawnCoroutine != null)
        {
            StopCoroutine(spawnCoroutine);
        }
    }

    private IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(0.5f);

        while (true)
        {
            float waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(waitTime);

            float randomX = Random.Range(screenRight, screenRight + 5f);
            float randomY = Random.Range(screenBottom, screenTop);

            Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
        //GameObject cloud = Instantiate(prefab, transform.position, Quaternion.identity);
        //Pipes pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        //pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        //pipes.gap = verticalGap;
    }

}
