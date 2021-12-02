using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HotKeys : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject FPS;
    
    bool menuOpened = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuOpened == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_Start_Menu");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;

        pauseMenu.SetActive(false);
        menuOpened = false;
    }


    void Pause()
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;

        pauseMenu.SetActive(true);
        menuOpened = true;
    }


}
