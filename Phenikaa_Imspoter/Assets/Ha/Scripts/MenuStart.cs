using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour
{
    public void PlayStory()
    {
        SceneManager.LoadScene("HyuNie/Scenes/HyuNieScene");
    }
    public void PlayEndless()
    {
        SceneManager.LoadScene("EndlessScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
