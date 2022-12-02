using UnityEngine;
using UnityEngine.Events;

public class AnnounceCollision : MonoBehaviour
{
    public UnityEvent onCollisionDetected;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            onCollisionDetected.Invoke();
        }
    }
}
