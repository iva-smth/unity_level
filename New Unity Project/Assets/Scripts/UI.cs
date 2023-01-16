using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;
    
    public void UpdateText(string str) 
    {
        promptText.text = str;
    }
}
