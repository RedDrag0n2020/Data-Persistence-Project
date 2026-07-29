using UnityEditor;
using UnityEngine;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{

    //public TMP_InputField inputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNameEntered()
    {
        //PersistentDataManager.playerName = inputField.text;
        PlayerPrefs.SetString("PlayerNameTemp", name);
        
        
        Debug.Log("Player name saved in PlayerPrefs: " + PersistentDataManager.playerName);

    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
          EditorApplication.ExitPlaymode();
        #else
          Application.Quit(); 
        #endif
    }
}
