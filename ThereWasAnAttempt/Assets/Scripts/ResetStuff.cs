using UnityEngine;

public class ResetStuff : MonoBehaviour
{
    [SerializeField] private AudioSource finalAudio;
    [SerializeField] private AudioSource mainAudio;
    [SerializeField] private GameObject[] spikeWalls;
    [SerializeField] private AnnounceFinalPlatform fpClass;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            finalAudio.Stop();
            mainAudio.Play();

            foreach (var wall in spikeWalls)
            {
                wall.SetActive(false);
            }

            fpClass.firstLand = false;
        }
    }
}
