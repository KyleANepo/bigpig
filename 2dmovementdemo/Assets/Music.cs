using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    [SerializeField] AudioClip[] musicScores;
    private AudioSource musicPlayer;

    // Start is called before the first frame update
    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
        PlayMusic(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void PlayMusic(int scene)
    {
        if (musicPlayer.clip != musicScores[scene])
        {
            musicPlayer.clip = musicScores[scene];
            musicPlayer.Play();
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        if (scene.name == "SampleScene" )
            PlayMusic(1);

    }
}
