using UnityEngine;
using TMPro;

public class SetInactiveAfterTime : MonoBehaviour
{
    [SerializeField] private GameObject objToRemove;
    [SerializeField] private float inactiveTimer = 4f;
    [SerializeField] private TextMeshPro textToDisplay;

    public void StartCountdownTime()
    {
        textToDisplay.gameObject.SetActive(true);
        Invoke("SetObjectInactive", inactiveTimer);
    }

    void SetObjectInactive()
    {
        textToDisplay.gameObject.SetActive(false);
        objToRemove.SetActive(false);
        Invoke("SetObjectActive", 2);
    }

    void SetObjectActive()
    {
        objToRemove.SetActive(true);
    }
}
