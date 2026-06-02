using UnityEngine;
using TMPro;
using System;
using System.IO;

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

    [Serializable]
    public class PlayerData
    {
        public string name;
        public int score;
    }

    public void SavePlayerData()

    {
        PlayerData data = new PlayerData();
        data.name = playerName;
        data.score = playerScore;
        
        // Implementation for saving player data
        string jsonData = JsonUtility.ToJson(data);

        // Implementation for saving jsonData to a file or database
        File.WriteAllText(Application.persistentDataPath + "/playerData.json", jsonData);
        Debug.Log("Player data saved to: " +  jsonData);
        Debug.Log(Application.persistentDataPath + "/playerData.json");
    }

    public void LoadPlayerData()
    {
        string filePath = Application.persistentDataPath + "/playerData.json";
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            PlayerData data = JsonUtility.FromJson<PlayerData>(jsonData);
            playerName = data.name;
            playerScore = data.score;
            Debug.Log("Player data loaded: " + jsonData);
        }
        else
        {
            Debug.LogWarning("No player data found to load.");
        }
    }
}
