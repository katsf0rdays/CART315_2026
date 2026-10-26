using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1.5f;
    private float screenLeft;
    private float screenRight;
    private float screenBottom;
    private float screenTop;
    //public float spawnRate = 1f;
    //public float minHeight = -1f;
    //public float maxHeight = 2f;
    //public float verticalGap = 3f;

    private void Start()
    {
        Camera cam = Camera.main;
        screenLeft = cam.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 2f;
        screenRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x + 2f;
        screenBottom = cam.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;
        screenTop = cam.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;

        InvokeRepeating(nameof(Spawn), 0f, spawnRate);

    }
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        float randomX = Random.Range(screenLeft, screenRight);
        float randomY = Random.Range(screenBottom, screenTop);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);
        Instantiate(prefab, spawnPosition, Quaternion.identity);
        //GameObject cloud = Instantiate(prefab, transform.position, Quaternion.identity);
        //Pipes pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        //pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        //pipes.gap = verticalGap;
    }

}
