using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashscreenscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("movetosmartfactoryscreen", 5f);
    }

    // Update is called once per frame
   public void movetosmartfactoryscreen()
    {
        SceneManager.LoadScene("Middlescene");
    }
}
