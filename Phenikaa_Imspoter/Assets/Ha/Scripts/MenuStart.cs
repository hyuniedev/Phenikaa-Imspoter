using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    public void PlayStory()
    {
        SceneManager.LoadScene("StoryScreen");
    }
    public void PlayEndless()
    {
        SceneManager.LoadScene("EndlessScreen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
