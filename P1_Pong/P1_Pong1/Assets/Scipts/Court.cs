using UnityEngine;
using UnityEngine.EventSystems;

public class Court : MonoBehaviour
{
    public EventTrigger.TriggerEvent courtTrigger;

    public void OnCollisionEnter2D(Collision2D other)
    {
        BaseEventData eventData = new BaseEventData(EventSystem.current);
        courtTrigger.Invoke(eventData);
    }

}
