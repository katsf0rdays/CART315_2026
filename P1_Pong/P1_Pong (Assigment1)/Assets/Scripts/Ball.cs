using System;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    public float speed = 12.0f;
    public Camera mainCamera;
    public Color collisionColor;

    [Header("MultiBall Settings")]
    public GameObject ballPrefab;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        mainCamera = Camera.main;

        if (mainCamera != null)
            mainCamera.clearFlags = CameraClearFlags.SolidColor;

        collisionColor = Random.ColorHSV();


    }

    private void Update()
    {
        collisionColor = Random.ColorHSV();
    }

    private void FixedUpdate()
    {
        if (_rigidBody.linearVelocity.sqrMagnitude > 0.01f)
        {
            _rigidBody.linearVelocity = _rigidBody.linearVelocity.normalized * speed;
        }
    }

    public void ResetBall()
    {
        _rigidBody.linearVelocity = Vector2.zero;
        _rigidBody.angularVelocity = 0;
        transform.position = Vector3.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = (Random.value < 0.5f ? -1.0f : 1.0f) * Random.Range(0.5f, 0.9f);

        Vector2 direction = new Vector2(x, y);

        _rigidBody.linearVelocity = direction * speed;

        GameObject newBallObject = Instantiate(ballPrefab, Vector3.zero, Quaternion.identity);

        Ball newBallScript = newBallObject.GetComponent<Ball>();

        if (newBallScript != null)
        {
            newBallScript.AddStartingForce();
        }
    
        else
        {
            Debug.LogWarning("Please drag your Ball Prefab into the 'Ball Prefab' slot in the Inspector!");
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
            mainCamera.backgroundColor = collisionColor;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager gameManager = FindFirstObjectByType<GameManager>();

        if (gameManager != null)
        {
            if (other.CompareTag("CourtLeft"))
            {
                gameManager.CourtTriggered(0);
            }
            else if (other.CompareTag("CourtRight"))
            {
                gameManager.CourtTriggered(1);
            }
        }
    }

}








