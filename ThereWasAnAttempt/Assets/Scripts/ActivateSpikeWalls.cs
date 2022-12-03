using UnityEngine;

public class ActivateSpikeWalls : MonoBehaviour
{
    [SerializeField] GameObject[] spikeWalls;

    public void ActivateWalls()
    {
        spikeWalls[0].transform.position = new Vector3(-4.8f, 57.8f, 61.5f);
        spikeWalls[0].SetActive(true);

        spikeWalls[1].transform.position = new Vector3(4.8f, 57.8f, 61.5f);
        spikeWalls[1].SetActive(true);
    }
}
