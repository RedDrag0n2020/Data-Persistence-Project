using UnityEngine;
using TMPro;

public class PersistentDataManager : MonoBehaviour
{
    public static PersistentDataManager Instance;

    public static string playerName = "";

    public static int playerScore = 0;

    public TMP_InputField inputField;

    public TMP_InputField scoreField;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        
    }

    public void SaveName()
    {
        playerName = inputField.text;
        Debug.Log("Player name saved: " + playerName);
    }

   
}
