using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{


    public void start(string scene)
    {
      
        SceneManager.LoadScene(scene);
    
    }

    public void BallScene(string BallScene)
    {
       
        SceneManager.LoadScene(BallScene);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void EndGame(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
