using UnityEngine;
using UnityEngine.Events;

public class AnnounceFinalPlatform : MonoBehaviour
{
    public UnityEvent onFinalPlatform;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            onFinalPlatform.Invoke();
        }
    }
}
