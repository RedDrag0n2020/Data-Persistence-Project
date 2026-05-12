using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    [SerializeField]  private float rotationSpeed = 90f; // Degrees per second   

    void Update()
    {
        transform.Rotate (0f, rotationSpeed * Time.deltaTime, 0f, Space.World);
    }
}
