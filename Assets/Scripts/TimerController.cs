using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite happySprite;
    [SerializeField] private Sprite neutralSprite;
    [SerializeField] private Sprite boredSprite;

    private Scene currentScene;
    public Image timer_image;
    float time_remaining;
    public float max_time = 4.0f;
    public float time_penalty = 0.25f;
    private float neutralTime;
    private float boredTime;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        time_remaining = max_time;
        neutralTime = max_time * (2 / 3f);
        boredTime = max_time * (1 / 3f);
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
            SceneManager.LoadScene("Game Over Screen");
        }
        if (time_remaining > neutralTime)
        {
            spriteRenderer.sprite = happySprite;
        }
        else if (time_remaining < neutralTime && time_remaining > boredTime)
        {
            spriteRenderer.sprite = neutralSprite;
        }
        else if (time_remaining < boredTime)
        {
            spriteRenderer.sprite = boredSprite;
        }
    }

    public void ResetTimer()
    {
        time_remaining = max_time;
    }

    public void WrongLetterPenalty()
    {
        time_remaining -= time_penalty;
    }
}
