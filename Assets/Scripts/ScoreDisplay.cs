using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;

    // public string scoreDisplayText = "Score:  ";

    void Start()
    {

        UpdateScoreUI();
        //    scoreText.text = scoreDisplayText + PersistentDataManager.playerScore;

    }

    void UpdateScoreUI()
    {
        // scoreText.text = "Score: " + ScoreManager.Instance.currentScore;
        scoreText.text = "Score: " + PersistentDataManager.Instance.playerData.score;

    }
}
