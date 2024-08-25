using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseManager : MonoBehaviour
{

    public GameObject startScreen;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        startScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
            startScreen.SetActive(false);
        }
    }



}
