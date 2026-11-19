using UnityEngine;

public class BubblePickup : MonoBehaviour
{
    [Header("Audio")]
    public AudioClip popSound;
    [Range(0f, 1f)]
    public float popVolume = 1f;

    private bool isCollected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isCollected && other.CompareTag("Player"))
        {
            isCollected = true;

            if (popSound != null)
            {
                AudioSource.PlayClipAtPoint(popSound, transform.position, popVolume);
            }

            CounterUI counter = FindFirstObjectByType<CounterUI>();
            if (counter != null)
            {
                counter.AddToCounter(1);
            }

            Destroy(gameObject);
        }
    }
}