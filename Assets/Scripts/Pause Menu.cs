using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject PauseButton;
    public GameObject ResumeButton;
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
            if(isPaused) 
            {
                ResumeGame(); 
            }

            else
            { 
                PauseGame(); 
            }   
       
    }

    public void PauseGame()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }   
    
    public void ResumeGame()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
