using UnityEngine;

public class UnderwaterCameraSway : MonoBehaviour
{
    public float swaySpeed = 1.2f;
    public float bobAmount = 0.08f;
    public float tiltAmount = 1.5f;

    private Vector3 startPos;
    private Quaternion startRot;

    void Start()
    {
        startPos = transform.localPosition;
        startRot = transform.localRotation;
    }

    void Update()
    {
        float bobY = Mathf.Sin(Time.time * swaySpeed) * bobAmount;
        float swayX = Mathf.Cos(Time.time * swaySpeed * 0.7f) * (bobAmount * 0.6f);
        float rollZ = Mathf.Sin(Time.time * swaySpeed * 0.8f) * tiltAmount;

        transform.localPosition = startPos + new Vector3(swayX, bobY, 0f);
        transform.localRotation = startRot * Quaternion.Euler(0f, 0f, rollZ);
    }
}