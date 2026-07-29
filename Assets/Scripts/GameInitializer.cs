using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PersistentDataManager.Instance.LoadPlayerData();

        if (PlayerPrefs.HasKey("PlayerNameTemp"))
        {
            PersistentDataManager.Instance.playerName  = PlayerPrefs.GetString("PlayerNameTemp");
            PlayerPrefs.DeleteKey("PlayerNameTemp");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
