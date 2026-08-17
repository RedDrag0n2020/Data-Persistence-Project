using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;


    //public TMP_InputField inputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SaveName()
    {
        string tempName = nameInput.text;
        PlayerPrefs.SetString("PlayerNameTemp", tempName);
        Debug.Log("Saved temp name: " + tempName);

    }
    public void OnStartGame()
    {
        
        SceneManager.LoadScene("Bootstrap");
    }

    //public void SaveName()
    //{
    //    playerData.name = inputField.text;
    //    Debug.Log("Player name saved: " + playerData.name);
    //}

    //public void OnNameEntered()
    //{
    //    //PersistentDataManager.playerName = inputField.text;
    //    PlayerPrefs.SetString("PlayerNameTemp", name);
        
        
    //    Debug.Log("Player name saved in PlayerPrefs: " + PersistentDataManager.Instance.playerData.name);

    //}

    public void ExitGame()
    {
        #if UNITY_EDITOR
          EditorApplication.ExitPlaymode();
        #else
          Application.Quit(); 
        #endif
    }
}
