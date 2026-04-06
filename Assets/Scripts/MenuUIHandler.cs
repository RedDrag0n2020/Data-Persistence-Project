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

    //public void SaveName()
    //{
    //    PersistentDataManager.playerName = inputField.text;
    //    Debug.Log("Player name saved: " + PersistentDataManager.playerName);

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
