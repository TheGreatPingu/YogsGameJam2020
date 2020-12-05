using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    
    void Update()
    {
        //getmousebuttondown(0) = left mouse button
        //this is temp til dan finishes the win/lose condition
        //when that is done this needs to be updated
        //actually this counts for the entire class :^)
        if(Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene().buildIndex == 0)
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        /**
         * each id is a new scene
         * 0 = title scene
         * 1 = main scene
         * 2 = end scene
         */
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            StartCoroutine(LoadLevel(1));
        } else if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            StartCoroutine(LoadLevel(2));
        }
        //StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);
    }
}
