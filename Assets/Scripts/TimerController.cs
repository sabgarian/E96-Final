using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private Scene currentScene;
    public Image timer_image;
    float time_remaining;
    public float max_time = 4.0f;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        time_remaining = max_time;
    }

    void Update()
    {
        if (time_remaining > 0)
        {
            time_remaining -= Time.deltaTime;
            timer_image.fillAmount = time_remaining / max_time;
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ResetTimer()
    {
        time_remaining = max_time;
    }
}
