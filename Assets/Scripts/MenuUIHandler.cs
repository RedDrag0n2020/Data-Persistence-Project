using UnityEditor;
using UnityEngine;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
