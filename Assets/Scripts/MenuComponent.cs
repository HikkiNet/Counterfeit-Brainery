using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuComponent : MonoBehaviour{
    public void MenuGameStart(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MenuGameExit(){
        Application.Quit();
    }
}
