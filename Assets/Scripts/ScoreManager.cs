//using Unity.VisualScripting;
using UnityEngine;
//using TMPro;

public class ScoreManager : MonoBehaviour
{
        public int currentScore = 0;
    [SerializeField] private int scoreToAdd = 10;

    public static ScoreManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Increment the score or perform any desired action when the player collides with this object
            Debug.Log("Player collided with gold!");

            CalculateScore();
            Debug.Log("Score: " + currentScore);
        }
    }

    private int CalculateScore()
    {
        // Implement your score calculation logic here
        // For example, you can add a fixed amount to the current score
        return currentScore = currentScore + scoreToAdd;
    }
}

