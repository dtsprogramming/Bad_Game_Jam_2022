using UnityEngine;

public class DeathWalls : MonoBehaviour
{
    [SerializeField] private Transform wall1;
    [SerializeField] private Transform wall2;
    [SerializeField] private float moveSpeed = 0.02f;

    void Update()
    {
        LeftWall();
        RightWall();
    }

    private void RightWall()
    {
        wall2.Translate(0, -moveSpeed * Time.deltaTime, 0);
    }

    private void LeftWall()
    {
        wall1.Translate(0, -moveSpeed * Time.deltaTime, 0);
    }
}
