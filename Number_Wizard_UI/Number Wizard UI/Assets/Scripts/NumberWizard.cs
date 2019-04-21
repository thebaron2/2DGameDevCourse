using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        CalculateGuess();
    }

    public void OnPressHigher()
    {
        if ((guess + 1) <= max)
        {
            min = guess + 1;
            CalculateGuess();
        }
    }

    public void OnPressLower()
    {
        if ((guess - 1) >= min)
        {
            max = guess - 1;
            CalculateGuess();
        }
    }

    void CalculateGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
