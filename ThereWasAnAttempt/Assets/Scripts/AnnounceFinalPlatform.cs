using UnityEngine;
using UnityEngine.Events;

public class AnnounceFinalPlatform : MonoBehaviour
{
    [HideInInspector]
    public bool firstLand = false;

    public UnityEvent onFinalPlatform;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" && !firstLand)
        {
            // Prevents invoking final platform element with each jump
            firstLand = true;
            onFinalPlatform.Invoke();
        }
    }
}
