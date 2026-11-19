using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class DoubleDoorTrigger : MonoBehaviour
{
    [Header("Door Hinges")]
    public Transform leftHinge;
    public Transform rightHinge;

    [Header("Swing Settings")]
    public float openAngle = 90f;
    public float swingSpeed = 3f;

    [Header("Audio")]
    public AudioClip doorOpenSound;
    [Range(0f, 1f)]
    public float openVolume = 1f;
    public AudioClip doorCloseSound;
    [Range(0f, 1f)]
    public float closeVolume = 1f;

    private AudioSource audioSource;

    private Quaternion leftClosedRot;
    private Quaternion rightClosedRot;
    private Quaternion leftTargetRot;
    private Quaternion rightTargetRot;
    private int playersInZone = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        leftClosedRot = leftHinge.localRotation;
        rightClosedRot = rightHinge.localRotation;
        leftTargetRot = leftClosedRot;
        rightTargetRot = rightClosedRot;
    }

    void Update()
    {
        leftHinge.localRotation = Quaternion.Slerp(leftHinge.localRotation, leftTargetRot, Time.deltaTime * swingSpeed);
        rightHinge.localRotation = Quaternion.Slerp(rightHinge.localRotation, rightTargetRot, Time.deltaTime * swingSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            playersInZone++;
            if (playersInZone == 1)
            {
                OpenDoors(other.transform.position);
                if (doorOpenSound != null)
                {
                    audioSource.PlayOneShot(doorOpenSound, openVolume);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playersInZone--;
            if (playersInZone <= 0)
            {
                playersInZone = 0;
                leftTargetRot = leftClosedRot;
                rightTargetRot = rightClosedRot;

                if (doorCloseSound != null)
                {
                    audioSource.PlayOneShot(doorCloseSound, closeVolume);
                }
            }
        }
    }

    private void OpenDoors(Vector3 playerPos)
    {
        // Check whether the player is in front of or behind the door
        Vector3 directionToPlayer = (playerPos - transform.position).normalized;
        float dot = Vector3.Dot(transform.forward, directionToPlayer);

        // Swing away from the player regardless of which side they approach from
        float swingDirection = (dot >= 0) ? -1f : 1f;

        leftTargetRot = leftClosedRot * Quaternion.Euler(0f, openAngle * swingDirection, 0f);
        rightTargetRot = rightClosedRot * Quaternion.Euler(0f, -openAngle * swingDirection, 0f);
    }
}