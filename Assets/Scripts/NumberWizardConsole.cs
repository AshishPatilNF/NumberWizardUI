using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NumberWizardConsole : MonoBehaviour
{
    [SerializeField]
    int maximum;

    [SerializeField]
    int minimum;

    int guess;

    [SerializeField]
    TextMeshProUGUI text;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            OnPressHigher();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            OnPressLower();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(2);
        }
    }

    void NextGuess()
    {
        guess = Random.Range(maximum, minimum);
        text.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        if (guess == 1000)
        {
            guess = 1000;
        }
        else if (guess == 1)
        {
            guess = 1;
        }
        else
        {
            minimum = guess + 1;
            NextGuess();
        }
    }

    public void OnPressLower()
    {
        if (guess == 1000)
        {
            guess = 1000;
        }
        else if (guess == 1)
        {
            guess = 1;
        }
        else
        {
            maximum = guess - 1;
            NextGuess();
        }
    }
}
