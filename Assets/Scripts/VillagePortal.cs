using UnityEngine;
using UnityEngine.SceneManagement;

public class VillagePortal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Load the next scene in the build index
            // SceneManager.LoadScene("Exit");
            SceneManager.LoadScene("Exit");
        }
        else
        {
            Debug.LogWarning("Couldn't Load Scene!");

        }

    }
}
