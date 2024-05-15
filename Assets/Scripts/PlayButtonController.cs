using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonController : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Living Room");
    }
}
