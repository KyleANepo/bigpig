using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] private Transform playerCheck;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private GameObject ending;

    private float endingTimer = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsExit())
        {
            if (Input.GetMouseButtonDown(0) && !GameManager.Instance.End)
            {
                GameManager.Instance.End = true;
                ending.SetActive(true);
            }
        }

        if (GameManager.Instance.End)
        {
            endingTimer -= Time.deltaTime;
        }

        if (endingTimer < 0)
        {
            NextLevel();
        }
    }

    bool IsExit()
    {
        return Physics2D.OverlapCircle(playerCheck.position, 0.2f, playerLayer);
    }

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No next found!");
        }
    }
}
