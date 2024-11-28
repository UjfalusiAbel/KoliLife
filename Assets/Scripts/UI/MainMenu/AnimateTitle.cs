using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AnimateTitle : MonoBehaviour
{
    [SerializeField]
    private Text textDisplay;
    private string firstWord = "KoliLife \n";
    private string secondWord = "Experience";
    private float typingSpeed = 0.1f;
    private string currentText = "";
    private const string colorOpen = "<color=#feae34>";
    private const string colorClose = "</color>";

    void Start()
    {
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        for (int i = 0; i <= firstWord.Length; i++)
        {
            currentText = string.Concat(colorOpen, firstWord.Substring(0, i));
            currentText = string.Concat(currentText, colorClose);
            textDisplay.text = currentText;
            yield return new WaitForSeconds(typingSpeed);
        }

        for (int i = 0; i <= secondWord.Length; i++)
        {
            textDisplay.text = string.Concat(currentText, secondWord.Substring(0, i));
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
