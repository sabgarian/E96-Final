using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsBackButtonController : MonoBehaviour
{
    [SerializeField] private GameObject currentScreen;
    [SerializeField] private GameObject mainMenu;

    public void CreditsBackButton()
    {
        currentScreen.SetActive(false);
        mainMenu.SetActive(true);
    }
}
