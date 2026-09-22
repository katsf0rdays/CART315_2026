using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    public float speed = 100.0f;
    public Camera mainCamera;
    public Color collisionColor;

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

        _rigidBody.AddForce(direction * speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
            mainCamera.backgroundColor = collisionColor;
        else if (collision.gameObject.CompareTag("Paddle"))
            mainCamera.backgroundColor = collisionColor;

    }
}








