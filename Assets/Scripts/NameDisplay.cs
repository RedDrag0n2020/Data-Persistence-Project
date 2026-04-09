using TMPro;
using UnityEngine;

public class NameDisplay : MonoBehaviour
{
    public TMP_Text nameText;

    public string nameDisplayText = "Name:  ";

    void Start()
    {
       nameText.text = nameDisplayText + PersistentDataManager.playerName;
        
    }
}