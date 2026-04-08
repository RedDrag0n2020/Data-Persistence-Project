using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToVillage()
    {
        SceneManager.LoadScene("Village");
    }

    public void GoToTemple()
    {
        SceneManager.LoadScene("Temple");
    }
}
