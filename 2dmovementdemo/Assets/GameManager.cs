using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    // Pause menu stuff. Maybe put in something else if considering different scenes?
    public GameObject PauseMenu;
    public Player player;
    public bool Paused;
    public bool Dead;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !Paused)
        {
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Paused)
        {
            ResumeGame();
        }

        IsDead();
    }

    public void IsDead()
    {
        if (Dead)
        { 
            if (Input.GetButtonDown("Jump"))
            {
                Dead = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void ButtonPause()
    {
        if (!Paused)
        {
            PauseGame();
        }
        else if (Paused)
        {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        Paused = true;
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    private void ResumeGame()
    {
        Paused = false;
        Time.timeScale = 1.0f;
        PauseMenu.SetActive(false);
    }

    public void QuitToMain()
    {
        ResumeGame();
        SceneManager.LoadScene("MainMenu");
    }
}
