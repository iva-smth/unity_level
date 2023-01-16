using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class Quit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
        {
            Application.Quit();    // закрыть приложение
        }
    }
}