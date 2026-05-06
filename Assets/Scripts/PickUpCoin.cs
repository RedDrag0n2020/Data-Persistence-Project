using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    [SerializeField] private int scoreToAdd = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with coin!");

            ScoreManager.Instance.AddScore(scoreToAdd);

            Destroy(gameObject);
        }
    }
}
