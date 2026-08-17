using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Collections;

public class GameInitializer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        // Allow PersistentDataManager.Awake() to run
        Debug.Log("BOOTSTRAP: Start() running");
        yield return null;

        // Load saved data
        PersistentDataManager.Instance.LoadPlayerData();

        // Apply temp name from Main Menu
        if (PlayerPrefs.HasKey("PlayerNameTemp"))
        {
            PersistentDataManager.Instance.playerData.name  = PlayerPrefs.GetString("PlayerNameTemp");
            PlayerPrefs.DeleteKey("PlayerNameTemp");
        }

        // Load the Village scene
        SceneManager.LoadScene("Village");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
