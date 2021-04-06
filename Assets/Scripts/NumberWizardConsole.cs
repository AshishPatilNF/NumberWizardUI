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
        guess = ((maximum + minimum) / 2);
        text.text = guess.ToString();
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
        guess = (maximum + minimum) / 2;
        text.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        minimum = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maximum = guess;
        NextGuess();
    }
}
