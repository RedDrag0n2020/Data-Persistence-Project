using TMPro;
using UnityEngine;

public class NameDisplay : MonoBehaviour
{
    public TMP_Text nameText;

    public string nameDisplayText = "Score:  ";

    void Start()
    {
       nameText.text = nameDisplayText + PersistentDataManager.playerName;
        
    }
}