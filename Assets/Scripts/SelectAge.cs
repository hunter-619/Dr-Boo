using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectAge : MonoBehaviour
{
    public void loadAge()
    {
        SceneManager.LoadScene("Age");
    }
}
