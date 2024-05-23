using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;
    [SerializeField] private GameObject ResumeButton;
    [SerializeField] private GameObject PauseButton;

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
        Time.timeScale = 0;
    }   
    
    public void ResumeGame()
    {
        PauseButton.SetActive(true);
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
