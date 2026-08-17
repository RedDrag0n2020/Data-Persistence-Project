using UnityEngine;
using TMPro;
using System;
using System.IO;
using UnityEngine.SceneManagement;


public class PersistentDataManager : MonoBehaviour
{
    public static PersistentDataManager Instance;

    public PlayerData playerData = new PlayerData();

    //public static string playerName = "";

    // public static int playerScore = 0;

    //public TMP_InputField inputField;

    ///public TMP_InputField scoreField;



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

    void LoadVillage()   { SceneManager.LoadScene("Village");}

    //public void SaveName()
    //{
    //    playerData.name = inputField.text;
    //    Debug.Log("Player name saved: " + playerData.name);
    //}

    [Serializable]
    public class PlayerData
    {
        public string name;
        public int score;
        public float positionX;
        public float positionY;
        public float positionZ;

    }

    public void SavePlayerData()

    {
        PlayerData data = new PlayerData();
        data.name = playerData.name;
        data.score = playerData.score;
        
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
            playerData.name = data.name;
            playerData.score = data.score;
            Debug.Log("Player data loaded: " + jsonData);
        }
        else
        {
            Debug.LogWarning("No player data found to load.");
        }
    }
}
