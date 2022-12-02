using System;
using UnityEngine;

public class PlatformFlip : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private Transform platformTf;
    [SerializeField] private float resetTime = 3;

    private float currentRotation = -90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            platformTf.eulerAngles = new Vector3(0, 0, currentRotation);
        }

        Invoke("ResetPlatform", resetTime);
    }

    private void ResetPlatform()
    {
        platformTf.eulerAngles = new Vector3(0, 0, 0);
    }
}
