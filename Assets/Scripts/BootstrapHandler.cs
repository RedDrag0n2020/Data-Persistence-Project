using UnityEngine;
using UnityEngine.SceneManagement;

public class BootstrapHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PersistentDataManager.Instance.LoadPlayerData();
        SceneManager.LoadScene("Village");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
