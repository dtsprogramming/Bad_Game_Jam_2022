using UnityEngine;

public class PlatformSpeedBoost : MonoBehaviour
{
    [SerializeField] private float boostAmount = 1.5f;
    [SerializeField] private PlayerController playerController;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerController.moveSpeed = (playerController.moveSpeed * boostAmount);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerController.moveSpeed = (playerController.moveSpeed / boostAmount);
        }
    }

}
