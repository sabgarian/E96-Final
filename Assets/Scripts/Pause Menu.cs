using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;
    [SerializeField] private GameObject ResumeButton;
    [SerializeField] private GameObject PauseButton;
    [SerializeField] private GameObject Typer;
    [SerializeField] private GameObject TyperText;

    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        PauseButton.SetActive(false);
        PausePanel.SetActive(true);
        Typer.SetActive(false);
        TyperText.SetActive(false);
        Time.timeScale = 0;
    }   
    
    public void ResumeGame()
    {
        isPaused = false;
        PauseButton.SetActive(true);
        PausePanel.SetActive(false);
        Typer.SetActive(true);
        TyperText.SetActive(true);
        Time.timeScale = 1f;
    }
}
