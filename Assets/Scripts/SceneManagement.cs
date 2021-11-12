using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void LoadScene(){
        SceneManager.LoadScene("ARScene");
    }
    public void Exit(){
        Application.Quit();
    }

    public void BackToMenu(){
        SceneManager.LoadScene("MenuScene");
    }

}
