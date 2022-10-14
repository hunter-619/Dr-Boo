using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Update is called once per frame
    public void startMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
