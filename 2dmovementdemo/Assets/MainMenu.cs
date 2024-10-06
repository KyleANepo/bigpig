using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    enum Menu { Start, Level };

    Menu Current;

    // Start is called before the first frame update
    void Start()
    {
        Current = Menu.Start;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Current == Menu.Start)
            {
                Current = Menu.Level;
            }
            else if (Current == Menu.Level)
            {
                Current = Menu.Start;
            }
        }
    }
}
