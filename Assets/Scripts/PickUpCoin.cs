using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    [SerializeField] private int scoreToAdd = 5;
    [SerializeField] private AudioClip pickupCoinSound;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Play Sound
            AudioSource playerAudio = collision.gameObject.GetComponent<AudioSource>();
            if (playerAudio != null && pickupCoinSound != null)
            {
                playerAudio.PlayOneShot(pickupCoinSound);
            }

            //Add Score
            Debug.Log("Player collided with coin!");
            ScoreManager.Instance.AddScore(scoreToAdd);

            //Destroy Coin
            Destroy(gameObject);
        }
    }
}
