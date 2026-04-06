using UnityEngine;

public class PersistentDataManager : MonoBehaviour
{
    public static PersistentDataManager Instance;

    public string playerName;

    public int playerScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
