using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    private TextMeshProUGUI textObject;
    private string text;
    private string textToDisplay;
    private float typeRate = 0.05f;
    private float typingStart;
    private int lettersTyped;

    private void Start()
    {
        textObject = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (text != "" && text != textToDisplay) 
        {
            TypeText();
        }
    }

    public void SetText(string newText) 
    {
        textToDisplay = "";
        text = newText;
        typingStart = Time.time;
        lettersTyped = 0;

        if (text == "") 
        {
            textObject.text = "";
        }
    }

    private void TypeText() 
    {
        lettersTyped = (int)Math.Floor((Time.time - typingStart) / typeRate);

        textToDisplay = text.Substring(0, Math.Min(lettersTyped, text.Length));

        textObject.text = textToDisplay;
    }
}
