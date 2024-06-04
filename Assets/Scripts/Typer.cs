using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Typer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] spriteArray;

    [SerializeField] private AudioSource SFXSource;

    public WordBank wordBank = null;
    public Text wordOutput = null;

    public TimerController timer;

    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;
    private int spriteIndex;
    private int indexTracker;

    private void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        currentWord = wordBank.GetWord();
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if(Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if (keysPressed.Length == 1)
            {
                EnterLetter(keysPressed);
            }
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if(IsCorrectLetter(typedLetter))
        {
            RemoveLetter();

            if(IsWordComplete())
            {
                spriteIndex = Random.Range(0, spriteArray.Length);
                while (spriteIndex == indexTracker)
                    spriteIndex = Random.Range(0, spriteArray.Length);
                spriteRenderer.sprite = spriteArray[spriteIndex];
                indexTracker = spriteIndex;
                timer.ResetTimer();
                SFXSource.Play();

                SetCurrentWord();
            }
        }
        else
        {
            timer.WrongLetterPenalty();
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }
    
    private bool IsWordComplete()
    {
        return remainingWord.Length == 0;
    }
}
