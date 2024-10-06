using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    enum Menu { Start, Episode1, Episode2, Episode3, Back };

    Menu Current;

    public GameObject StartMenu;
    public GameObject LevelSelect;

    public bool Intro = true;

    // Start is called before the first frame update
    void Start()
    {
        Current = Menu.Start;
        StartMenu.SetActive(false);
        LevelSelect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void IntroOver()
    {
        StartMenu.SetActive(true);
        LevelSelect.SetActive(false);
    }

    public void PressStart()
    {
        StartMenu.SetActive(false);
        LevelSelect.SetActive(true);
    }

    public void PressBack()
    {
        StartMenu.SetActive(true);
        LevelSelect.SetActive(false);
    }

    public void Press1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Press2()
    {
        SceneManager.LoadScene("");
    }

    public void Press3()
    {
        SceneManager.LoadScene("");
    }
}
