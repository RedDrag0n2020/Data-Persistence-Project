using UnityEngine;

public class PickupIngot : MonoBehaviour
{
    [SerializeField] private int scoreToAdd = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with gold!");

            ScoreManager.Instance.AddScore(scoreToAdd);

            Destroy(gameObject);
        }
    }
}
