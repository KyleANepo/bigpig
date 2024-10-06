using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour
{
    public MainMenu Menu;
    public Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Menu.Intro == true)
        {
            Animator.Play("intro6");
        }
    }

    private void IntroOver()
    {
        Menu.Intro = false;
        Menu.IntroOver();
    }
}
