using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;
    [SerializeField] private GameObject ResumeButton;
    [SerializeField] private GameObject PauseButton;
    [SerializeField] private GameObject Typer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        PauseButton.SetActive(false);
        PausePanel.SetActive(true);
        Typer.SetActive(false);
        Time.timeScale = 0;
    }   
    
    public void ResumeGame()
    {
        PauseButton.SetActive(true);
        PausePanel.SetActive(false);
        Typer.SetActive(true);
        Time.timeScale = 1f;
    }
}
