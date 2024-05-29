using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButtonController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject creditsScreen;

    public void CreditsButton()
    {
        mainMenu.SetActive(false);
        creditsScreen.SetActive(true);
    }

}
