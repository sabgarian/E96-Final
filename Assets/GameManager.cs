using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private string mostRecentLevel;
    // Start is called before the first frame update

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        string name = scene.name;
        if (name[0] == 'L')
        {  // living room 
            mostRecentLevel = name;
        }
        Debug.Log(mostRecentLevel);
    }

    public void PlayMostRecentScene()
    {
        SceneManager.LoadScene(mostRecentLevel);
    }
}
