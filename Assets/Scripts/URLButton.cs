using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenURL()
    {
        Application.OpenURL("https://www.kimberly-clark.com/en-us/brands/baby-and-child-care");
        Debug.Log("URL Working");
    }
}
