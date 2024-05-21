using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//video credit:https://youtu.be/ZmQAHhZ7784?si=YO4LNGAEaSf7nv2b
public class MuteButton : MonoBehaviour
{
   private Sprite soundOnImage;
   public Sprite soundOffImage;
   public Button button;
   private bool isOn = true;
   public AudioSource audioSource;

    void Start()
    {
        soundOnImage = button.image.sprite;
    }

    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
